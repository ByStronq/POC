using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, EfContext>, IEmployeeDal
    {
        public Employee GetWithDetails(Expression<Func<Employee, bool>> filter)
        {
            using (EfContext context = new EfContext())
            {
                return context.Set<Employee>().SingleOrDefault(filter);
            }
        }
        public IEnumerable<Employee> GetAllWithDetails(Expression<Func<Employee, bool>> filter = null)
        {
            using (EfContext context = new EfContext())
            {
                return filter == null
                    ? context.Set<Employee>().Select(entity => entity)
                    : context.Set<Employee>().Where(filter).Select(entity => entity);
            }
        }
    }
}
