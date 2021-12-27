using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentAssignmentDal : EfEntityRepositoryBase<DepartmentAssignment, EfContext>, IDepartmentAssignmentDal
    {

    }
}
