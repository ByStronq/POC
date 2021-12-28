using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(
            IMapper mapper,
            IEmployeeDal employeeDal
        ) {
            _mapper = mapper;
            _employeeDal = employeeDal;
        }

        public IResult Add(EmployeeCreateDto employee)
        {
            _employeeDal.Add(_mapper.Map<Employee>(employee));
            return new SuccessResult();
        }

        public IResult Update(EmployeeUpdateDto employee)
        {
            _employeeDal.Update(_mapper.Map<Employee>(employee));
            return new SuccessResult();
        }

        public IResult Delete(int employeeId)
        {
            _employeeDal.Delete(new Employee { Id = employeeId });
            return new SuccessResult();
        }

        public IDataResult<EmployeeDto> Get(int employeeId)
            => new SuccessDataResult<EmployeeDto>(
                _mapper.Map<EmployeeDto>(
                    _employeeDal.Get(
                        employee => employee.Id == employeeId)));

        public IDataResult<EmployeeDetailDto> GetWithDetails(int employeeId)
            => new SuccessDataResult<EmployeeDetailDto>(
                _mapper.Map<EmployeeDetailDto>(
                    _employeeDal.GetWithDetails(
                        employee => employee.Id == employeeId)));

        public IDataResult<IEnumerable<EmployeeDto>> GetAll()
            => new SuccessDataResult<IEnumerable<EmployeeDto>>(
                _mapper.Map<IEnumerable<EmployeeDto>>(
                    _employeeDal.GetAll()));

        public IDataResult<IEnumerable<EmployeeDetailDto>> GetAllWithDetails()
            => new SuccessDataResult<IEnumerable<EmployeeDetailDto>>(
                _mapper.Map<IEnumerable<EmployeeDetailDto>>(
                    _employeeDal.GetAllWithDetails()));
    }
}
