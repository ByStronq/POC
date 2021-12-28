using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IDepartmentAssignmentService
    {
        IResult Add(DepartmentAssignmentCreateDto departmentAssignment);
        IResult Update(DepartmentAssignmentUpdateDto departmentAssignment);
        IResult Delete(int departmentAssignmentId);
        IDataResult<DepartmentAssignmentDto> Get(int departmentAssignmentId);
        IDataResult<DepartmentAssignmentDetailDto> GetWithDetails(int departmentAssignmentId);
        IDataResult<IEnumerable<DepartmentAssignmentDto>> GetAll();
        IDataResult<IEnumerable<DepartmentAssignmentDetailDto>> GetAllWithDetails();
    }
}
