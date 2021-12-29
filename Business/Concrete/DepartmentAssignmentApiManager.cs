using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class DepartmentAssignmentApiManager : IDepartmentAssignmentApiService
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentAssignmentApiConsumer _departmentAssignmentApiConsumer;

        public DepartmentAssignmentApiManager(
            IMapper mapper,
            IDepartmentAssignmentApiConsumer departmentAssignmentApiConsumer
        ) {
            _mapper = mapper;
            _departmentAssignmentApiConsumer = departmentAssignmentApiConsumer;
        }

        public async Task<IResult?> AddAsync(DepartmentAssignmentCreateDto departmentAssignment)
            => await _departmentAssignmentApiConsumer.Add(_mapper.Map<DepartmentAssignment>(departmentAssignment));

        public async Task<IResult?> UpdateAsync(DepartmentAssignmentUpdateDto departmentAssignment)
            => await _departmentAssignmentApiConsumer.Update(_mapper.Map<DepartmentAssignment>(departmentAssignment));

        public async Task<IResult?> DeleteAsync(int departmentAssignmentId)
            => await _departmentAssignmentApiConsumer.Delete(departmentAssignmentId);

        public async Task<IDataResult<DepartmentAssignmentDto>> GetAsync(int departmentAssignmentId)
            => _mapper.Map<IDataResult<DepartmentAssignmentDto>>(
                    await _departmentAssignmentApiConsumer.Get(departmentAssignmentId));

        public async Task<IDataResult<DepartmentAssignmentDetailDto>> GetWithDetailsAsync(int departmentAssignmentId)
            => _mapper.Map<IDataResult<DepartmentAssignmentDetailDto>>(
                    await _departmentAssignmentApiConsumer.GetWithDetails(departmentAssignmentId));

        public async Task<IDataResult<IEnumerable<DepartmentAssignmentDto>>> GetAllAsync()
            => _mapper.Map<IDataResult<IEnumerable<DepartmentAssignmentDto>>>(
                    await _departmentAssignmentApiConsumer.GetAll());

        public async Task<IDataResult<IEnumerable<DepartmentAssignmentDetailDto>>> GetAllWithDetailsAsync()
            => _mapper.Map<IDataResult<IEnumerable<DepartmentAssignmentDetailDto>>>(
                    await _departmentAssignmentApiConsumer.GetAllWithDetails());
    }
}
