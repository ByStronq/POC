using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Employee> GetWithDetailsAsync(Expression<Func<Employee, bool>> filter)
        {
            using (EfContext context = new EfContext())
            {
                return await context.Set<Employee>().SingleOrDefaultAsync(filter);
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

        public async Task<IEnumerable<Employee>> GetAllWithDetailsAsync(Expression<Func<Employee, bool>> filter = null)
        {
            using (EfContext context = new EfContext())
            {
                return filter == null
                    ? await context.Set<Employee>().ToListAsync()
                    : await context.Set<Employee>().Where(filter).ToListAsync();
            }
        }
    }
}
