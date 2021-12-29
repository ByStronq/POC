using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class EmployeeApiManager : IEmployeeApiService
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeApiConsumer _employeeApiConsumer;

        public EmployeeApiManager(
            IMapper mapper,
            IEmployeeApiConsumer employeeApiConsumer
        ) {
            _mapper = mapper;
            _employeeApiConsumer = employeeApiConsumer;
        }

        public async Task<IResult?> AddAsync(EmployeeCreateDto employee)
            => await _employeeApiConsumer.Add(_mapper.Map<Employee>(employee));

        public async Task<IResult?> UpdateAsync(EmployeeUpdateDto employee)
            => await _employeeApiConsumer.Update(_mapper.Map<Employee>(employee));

        public async Task<IResult?> DeleteAsync(int employeeId)
            => await _employeeApiConsumer.Delete(employeeId);

        public async Task<IDataResult<EmployeeDto>> GetAsync(int employeeId)
            => _mapper.Map<SerializeDataResult<EmployeeDto>>(
                    await _employeeApiConsumer.Get(employeeId));

        public async Task<IDataResult<EmployeeDetailDto>> GetWithDetailsAsync(int employeeId)
            => _mapper.Map<SerializeDataResult<EmployeeDetailDto>>(
                    await _employeeApiConsumer.GetWithDetails(employeeId));

        public async Task<IDataResult<IEnumerable<EmployeeDto>>> GetAllAsync()
            => _mapper.Map<SerializeDataResult<IEnumerable<EmployeeDto>>>(
                    await _employeeApiConsumer.GetAll());

        public async Task<IDataResult<IEnumerable<EmployeeDetailDto>>> GetAllWithDetailsAsync()
            => _mapper.Map<SerializeDataResult<IEnumerable<EmployeeDetailDto>>>(
                    await _employeeApiConsumer.GetAllWithDetails());
    }
}
