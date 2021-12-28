using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, EfContext>, IEmployeeDal
    {
        public Employee? GetWithDetails(Expression<Func<Employee, bool>> filter)
        {
            using (EfContext context = new EfContext())
            {
                return context.Set<Employee>()
                    .Include(entity => entity.DepartmentAssingments)
                    .SingleOrDefault(filter);
            }
        }

        public async Task<Employee?> GetWithDetailsAsync(Expression<Func<Employee, bool>> filter)
        {
            using (EfContext context = new EfContext())
            {
                return await context.Set<Employee>()
                    .Include(entity => entity.DepartmentAssingments)
                    .SingleOrDefaultAsync(filter);
            }
        }

        public IEnumerable<Employee> GetAllWithDetails(Expression<Func<Employee, bool>> filter = null)
        {
            using (EfContext context = new EfContext())
            {
                return filter == null
                    ? context.Set<Employee>()
                        .Include(entity => entity.DepartmentAssingments)
                        .Select(entity => entity)
                    : context.Set<Employee>()
                        .Include(entity => entity.DepartmentAssingments)
                        .Where(filter).Select(entity => entity);
            }
        }

        public async Task<IEnumerable<Employee>> GetAllWithDetailsAsync(Expression<Func<Employee, bool>> filter = null)
        {
            using (EfContext context = new EfContext())
            {
                return filter == null
                    ? await context.Set<Employee>()
                        .Include(entity => entity.DepartmentAssingments)
                        .ToListAsync()
                    : await context.Set<Employee>()
                        .Include(entity => entity.DepartmentAssingments)
                        .Where(filter).ToListAsync();
            }
        }
    }
}
