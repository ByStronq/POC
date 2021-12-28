using Core.DataAccess;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IDepartmentDal : IEntityRepository<Department>
    {
        Department? GetWithDetails(Expression<Func<Department, bool>> filter);
        Task<Department?> GetWithDetailsAsync(Expression<Func<Department, bool>> filter);
        IEnumerable<Department> GetAllWithDetails(Expression<Func<Department, bool>> filter = null);
        Task<IEnumerable<Department>> GetAllWithDetailsAsync(Expression<Func<Department, bool>> filter = null);
    }
}
