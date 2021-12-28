using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IResult Add(EmployeeCreateDto employee);
        Task<IResult> AddAsync(EmployeeCreateDto employee);
        IResult Update(EmployeeUpdateDto employee);
        Task<IResult> UpdateAsync(EmployeeUpdateDto employee);
        IResult Delete(int employeeId);
        Task<IResult> DeleteAsync(int employeeId);
        IDataResult<EmployeeDto> Get(int employeeId);
        Task<IDataResult<EmployeeDto>> GetAsync(int employeeId);
        IDataResult<EmployeeDetailDto> GetWithDetails(int employeeId);
        Task<IDataResult<EmployeeDetailDto>> GetWithDetailsAsync(int employeeId);
        IDataResult<IEnumerable<EmployeeDto>> GetAll();
        Task<IDataResult<IEnumerable<EmployeeDto>>> GetAllAsync();
        IDataResult<IEnumerable<EmployeeDetailDto>> GetAllWithDetails();
        Task<IDataResult<IEnumerable<EmployeeDetailDto>>> GetAllWithDetailsAsync();
    }
}
