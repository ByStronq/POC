using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IDepartmentAssignmentService
    {
        IResult Add(DepartmentAssignmentCreateDto departmentAssignment);
        Task<IResult> AddAsync(DepartmentAssignmentCreateDto departmentAssignment);
        IResult Update(DepartmentAssignmentUpdateDto departmentAssignment);
        Task<IResult> UpdateAsync(DepartmentAssignmentUpdateDto departmentAssignment);
        IResult Delete(int departmentAssignmentId);
        Task<IResult> DeleteAsync(int departmentAssignmentId);
        IDataResult<DepartmentAssignmentDto> Get(int departmentAssignmentId);
        Task<IDataResult<DepartmentAssignmentDto>> GetAsync(int departmentAssignmentId);
        IDataResult<DepartmentAssignmentDetailDto> GetWithDetails(int departmentAssignmentId);
        Task<IDataResult<DepartmentAssignmentDetailDto>> GetWithDetailsAsync(int departmentAssignmentId);
        IDataResult<IEnumerable<DepartmentAssignmentDto>> GetAll();
        Task<IDataResult<IEnumerable<DepartmentAssignmentDto>>> GetAllAsync();
        IDataResult<IEnumerable<DepartmentAssignmentDetailDto>> GetAllWithDetails();
        Task<IDataResult<IEnumerable<DepartmentAssignmentDetailDto>>> GetAllWithDetailsAsync();
    }
}
