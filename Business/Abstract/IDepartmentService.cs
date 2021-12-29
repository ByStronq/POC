using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IDepartmentService : IDepartmentApiService
    {
        IResult Add(DepartmentCreateDto department);
        IResult Update(DepartmentUpdateDto department);
        IResult Delete(int departmentId);
        IDataResult<DepartmentDto> Get(int departmentId);
        IDataResult<DepartmentDetailDto> GetWithDetails(int departmentId);
        IDataResult<IEnumerable<DepartmentDto>> GetAll();
        IDataResult<IEnumerable<DepartmentDetailDto>> GetAllWithDetails();
    }

    public interface IDepartmentApiService
    {
        Task<IResult?> AddAsync(DepartmentCreateDto department);
        Task<IResult?> UpdateAsync(DepartmentUpdateDto department);
        Task<IResult?> DeleteAsync(int departmentId);
        Task<IDataResult<DepartmentDto>> GetAsync(int departmentId);
        Task<IDataResult<DepartmentDetailDto>> GetWithDetailsAsync(int departmentId);
        Task<IDataResult<IEnumerable<DepartmentDto>>> GetAllAsync();
        Task<IDataResult<IEnumerable<DepartmentDetailDto>>> GetAllWithDetailsAsync();
    }
}
