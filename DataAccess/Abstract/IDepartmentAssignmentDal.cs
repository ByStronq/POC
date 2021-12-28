using Core.DataAccess;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IDepartmentAssignmentDal : IEntityRepository<DepartmentAssignment>
    {
        DepartmentAssignment GetWithDetails(Expression<Func<DepartmentAssignment, bool>> filter);
        Task<DepartmentAssignment> GetWithDetailsAsync(Expression<Func<DepartmentAssignment, bool>> filter);
        IEnumerable<DepartmentAssignment> GetAllWithDetails(Expression<Func<DepartmentAssignment, bool>> filter = null);
        Task<IEnumerable<DepartmentAssignment>> GetAllWithDetailsAsync(Expression<Func<DepartmentAssignment, bool>> filter = null);
    }
}
