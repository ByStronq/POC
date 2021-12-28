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

        public async Task<IResult> AddAsync(DepartmentAssignmentCreateDto departmentAssignment)
        {
            await _departmentAssignmentApiConsumer.Add(_mapper.Map<DepartmentAssignment>(departmentAssignment));
            return new SuccessResult();
        }

        public async Task<IResult> UpdateAsync(DepartmentAssignmentUpdateDto departmentAssignment)
        {
            await _departmentAssignmentApiConsumer.Update(_mapper.Map<DepartmentAssignment>(departmentAssignment));
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int departmentAssignmentId)
        {
            await _departmentAssignmentApiConsumer.Delete(departmentAssignmentId);
            return new SuccessResult();
        }

        public async Task<IDataResult<DepartmentAssignmentDto>> GetAsync(int departmentAssignmentId)
            => new SuccessDataResult<DepartmentAssignmentDto>(
                _mapper.Map<DepartmentAssignmentDto>(
                    await _departmentAssignmentApiConsumer.Get(departmentAssignmentId)));

        public async Task<IDataResult<DepartmentAssignmentDetailDto>> GetWithDetailsAsync(int departmentAssignmentId)
            => new SuccessDataResult<DepartmentAssignmentDetailDto>(
                _mapper.Map<DepartmentAssignmentDetailDto>(
                    await _departmentAssignmentApiConsumer.GetWithDetails(departmentAssignmentId)));

        public async Task<IDataResult<IEnumerable<DepartmentAssignmentDto>>> GetAllAsync()
            => new SuccessDataResult<IEnumerable<DepartmentAssignmentDto>>(
                _mapper.Map<IEnumerable<DepartmentAssignmentDto>>(
                    await _departmentAssignmentApiConsumer.GetAll()));

        public async Task<IDataResult<IEnumerable<DepartmentAssignmentDetailDto>>> GetAllWithDetailsAsync()
            => new SuccessDataResult<IEnumerable<DepartmentAssignmentDetailDto>>(
                _mapper.Map<IEnumerable<DepartmentAssignmentDetailDto>>(
                    await _departmentAssignmentApiConsumer.GetAllWithDetails()));
    }
}
