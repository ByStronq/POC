using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        IResult Add(DepartmentCreateDto department);
        Task<IResult> AddAsync(DepartmentCreateDto department);
        IResult Update(DepartmentUpdateDto department);
        Task<IResult> UpdateAsync(DepartmentUpdateDto department);
        IResult Delete(int departmentId);
        Task<IResult> DeleteAsync(int departmentId);
        IDataResult<DepartmentDto> Get(int departmentId);
        Task<IDataResult<DepartmentDto>> GetAsync(int departmentId);
        IDataResult<DepartmentDetailDto> GetWithDetails(int departmentId);
        Task<IDataResult<DepartmentDetailDto>> GetWithDetailsAsync(int departmentId);
        IDataResult<IEnumerable<DepartmentDto>> GetAll();
        Task<IDataResult<IEnumerable<DepartmentDto>>> GetAllAsync();
        IDataResult<IEnumerable<DepartmentDetailDto>> GetAllWithDetails();
        Task<IDataResult<IEnumerable<DepartmentDetailDto>>> GetAllWithDetailsAsync();
    }
}
