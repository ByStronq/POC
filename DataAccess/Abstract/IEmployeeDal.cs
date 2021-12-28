using Core.DataAccess;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
        Employee GetWithDetails(Expression<Func<Employee, bool>> filter);
        IEnumerable<Employee> GetAllWithDetails(Expression<Func<Employee, bool>> filter = null);
    }
}
