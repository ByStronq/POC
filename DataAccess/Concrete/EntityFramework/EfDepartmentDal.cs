using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentDal : EfEntityRepositoryBase<Department, EfContext>, IDepartmentDal
    {
        public Department GetWithDetails(Expression<Func<Department, bool>> filter)
        {
            using (EfContext context = new EfContext())
            {
                return context.Set<Department>().SingleOrDefault(filter);
            }
        }
        public IEnumerable<Department> GetAllWithDetails(Expression<Func<Department, bool>> filter = null)
        {
            using (EfContext context = new EfContext())
            {
                return filter == null
                    ? context.Set<Department>().Select(entity => entity)
                    : context.Set<Department>().Where(filter).Select(entity => entity);
            }
        }
    }
}
