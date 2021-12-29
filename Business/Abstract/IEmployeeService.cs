using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IEmployeeService : IEmployeeApiService
    {
        IResult Add(EmployeeCreateDto employee);
        IResult Update(EmployeeUpdateDto employee);
        IResult Delete(int employeeId);
        IDataResult<EmployeeDto> Get(int employeeId);
        IDataResult<EmployeeDetailDto> GetWithDetails(int employeeId);
        IDataResult<IEnumerable<EmployeeDto>> GetAll();
        IDataResult<IEnumerable<EmployeeDetailDto>> GetAllWithDetails();
    }

    public interface IEmployeeApiService
    {
        Task<IResult?> AddAsync(EmployeeCreateDto employee);
        Task<IResult?> UpdateAsync(EmployeeUpdateDto employee);
        Task<IResult?> DeleteAsync(int employeeId);
        Task<IDataResult<EmployeeDto>> GetAsync(int employeeId);
        Task<IDataResult<EmployeeDetailDto>> GetWithDetailsAsync(int employeeId);
        Task<IDataResult<IEnumerable<EmployeeDto>>> GetAllAsync();
        Task<IDataResult<IEnumerable<EmployeeDetailDto>>> GetAllWithDetailsAsync();
    }
}
