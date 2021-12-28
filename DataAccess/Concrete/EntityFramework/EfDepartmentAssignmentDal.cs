using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentAssignmentDal : EfEntityRepositoryBase<DepartmentAssignment, EfContext>, IDepartmentAssignmentDal
    {
        public DepartmentAssignment? GetWithDetails(Expression<Func<DepartmentAssignment, bool>> filter)
        {
            using (EfContext context = new EfContext())
            {
                return context.Set<DepartmentAssignment>()
                    .Include(entity => entity.Employee)
                    .Include(entity => entity.Department)
                    .SingleOrDefault(filter);
            }
        }

        public async Task<DepartmentAssignment?> GetWithDetailsAsync(Expression<Func<DepartmentAssignment, bool>> filter)
        {
            using (EfContext context = new EfContext())
            {
                return await context.Set<DepartmentAssignment>()
                    .Include(entity => entity.Employee)
                    .Include(entity => entity.Department)
                    .SingleOrDefaultAsync(filter);
            }
        }

        public IEnumerable<DepartmentAssignment> GetAllWithDetails(Expression<Func<DepartmentAssignment, bool>> filter = null)
        {
            using (EfContext context = new EfContext())
            {
                return filter == null
                    ? context.Set<DepartmentAssignment>()
                        .Include(entity => entity.Employee)
                        .Include(entity => entity.Department)
                        .Select(entity => entity)
                    : context.Set<DepartmentAssignment>()
                        .Include(entity => entity.Employee)
                        .Include(entity => entity.Department)
                        .Where(filter).Select(entity => entity);
            }
        }

        public async Task<IEnumerable<DepartmentAssignment>> GetAllWithDetailsAsync(Expression<Func<DepartmentAssignment, bool>> filter = null)
        {
            using (EfContext context = new EfContext())
            {
                return filter == null
                    ? await context.Set<DepartmentAssignment>()
                        .Include(entity => entity.Employee)
                        .Include(entity => entity.Department)
                        .ToListAsync()
                    : await context.Set<DepartmentAssignment>()
                        .Include(entity => entity.Employee)
                        .Include(entity => entity.Department)
                        .Where(filter).ToListAsync();
            }
        }
    }
}
