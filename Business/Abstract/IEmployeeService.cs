using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IResult Add(EmployeeCreateDto employee);
        IResult Update(EmployeeUpdateDto employee);
        IResult Delete(int employeeId);
        IDataResult<EmployeeDto> Get(int employeeId);
        IDataResult<EmployeeDetailDto> GetWithDetails(int employeeId);
        IDataResult<IEnumerable<EmployeeDto>> GetAll();
        IDataResult<IEnumerable<EmployeeDetailDto>> GetAllWithDetails();
    }
}
