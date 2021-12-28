using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentAssignmentDal : EfEntityRepositoryBase<DepartmentAssignment, EfContext>, IDepartmentAssignmentDal
    {
        public DepartmentAssignment GetWithDetails(Expression<Func<DepartmentAssignment, bool>> filter)
        {
            using (EfContext context = new EfContext())
            {
                return context.Set<DepartmentAssignment>().SingleOrDefault(filter);
            }
        }
        public IEnumerable<DepartmentAssignment> GetAllWithDetails(Expression<Func<DepartmentAssignment, bool>> filter = null)
        {
            using (EfContext context = new EfContext())
            {
                return filter == null
                    ? context.Set<DepartmentAssignment>().Select(entity => entity)
                    : context.Set<DepartmentAssignment>().Where(filter).Select(entity => entity);
            }
        }
    }
}
