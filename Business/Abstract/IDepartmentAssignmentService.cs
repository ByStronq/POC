using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IDepartmentAssignmentService : IDepartmentAssignmentApiService
    {
        IResult Add(DepartmentAssignmentCreateDto departmentAssignment);
        IResult Update(DepartmentAssignmentUpdateDto departmentAssignment);
        IResult Delete(int departmentAssignmentId);
        IDataResult<DepartmentAssignmentDto> Get(int departmentAssignmentId);
        IDataResult<DepartmentAssignmentDetailDto> GetWithDetails(int departmentAssignmentId);
        IDataResult<IEnumerable<DepartmentAssignmentDto>> GetAll();
        IDataResult<IEnumerable<DepartmentAssignmentDetailDto>> GetAllWithDetails();
    }

    public interface IDepartmentAssignmentApiService
    {
        Task<IResult?> AddAsync(DepartmentAssignmentCreateDto departmentAssignment);
        Task<IResult?> UpdateAsync(DepartmentAssignmentUpdateDto departmentAssignment);
        Task<IResult?> DeleteAsync(int departmentAssignmentId);
        Task<IDataResult<DepartmentAssignmentDto>> GetAsync(int departmentAssignmentId);
        Task<IDataResult<DepartmentAssignmentDetailDto>> GetWithDetailsAsync(int departmentAssignmentId);
        Task<IDataResult<IEnumerable<DepartmentAssignmentDto>>> GetAllAsync();
        Task<IDataResult<IEnumerable<DepartmentAssignmentDetailDto>>> GetAllWithDetailsAsync();
    }
}
