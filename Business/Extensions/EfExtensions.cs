using System.Linq.Expressions;
using System.Reflection;

namespace Business.Extensions
{
    public static class EfExtensions
    {
        public static IOrderedQueryable<TSource> OrderBy<TSource>(
         this IQueryable<TSource> query, string propertyName, bool isDesc = false, bool isThenBy = false)
        {
            string orderByMethodName = $"{(isThenBy ? "Then" : "Order")}By{(isDesc ? "Descending" : null)}";

            Type entityType = typeof(TSource);

            PropertyInfo propertyInfo = entityType.GetProperty(propertyName);

            ParameterExpression arg = Expression.Parameter(entityType, "x");
            MemberExpression property = Expression.Property(arg, propertyName);

            LambdaExpression selector = Expression.Lambda(property, new ParameterExpression[] { arg });

            Type enumarableType = typeof(Queryable);
            MethodInfo method = enumarableType.GetMethods()
                 .Where(m => m.Name == orderByMethodName && m.IsGenericMethodDefinition)
                 .Where(m =>
                 {
                     var parameters = m.GetParameters().ToList();
                     return parameters.Count == 2;
                 }).Single();

            MethodInfo genericMethod = method
                 .MakeGenericMethod(entityType, propertyInfo.PropertyType);

            var newQuery = (IOrderedQueryable<TSource>) genericMethod
                 .Invoke(genericMethod, new object[] { query, selector });
            return newQuery;
        }

        public static IOrderedQueryable<TSource> Where<TSource>(
         this IQueryable<TSource> query, string propertyName, string propertyValue, bool isEquality = false)
        {
            Type entityType = typeof(TSource);

            ParameterExpression arg = Expression.Parameter(entityType, "x");
            MemberExpression property = Expression.Property(arg, propertyName);

            ConstantExpression constantExpression = Expression.Constant(propertyValue, typeof(string));

            MethodInfo toString = typeof(Object).GetMethod("ToString");
            MethodInfo contains = typeof(string).GetMethod(isEquality ? "Equals" : "Contains", new[] { typeof(string) });

            MethodCallExpression toStringMethodExp = Expression.Call(property, toString);
            MethodCallExpression containsMethodExp = Expression.Call(toStringMethodExp, contains, constantExpression);

            LambdaExpression selector = Expression.Lambda(containsMethodExp, arg);

            Type enumarableType = typeof(Queryable);
            MethodInfo method = enumarableType.GetMethods()
                 .Where(m => m.Name == "Where" && m.IsGenericMethodDefinition)
                 .Where(m =>
                 {
                     var parameters = m.GetParameters().ToList();
                     return parameters.Count == 2;
                 }).FirstOrDefault();

            MethodInfo genericMethod = method
                 .MakeGenericMethod(entityType);

            var newQuery = (IOrderedQueryable<TSource>) genericMethod
                 .Invoke(genericMethod, new object[] { query, selector });
            return newQuery;
        }
    }
}
