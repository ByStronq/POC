using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class DepartmentApiManager : IDepartmentApiService
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentApiConsumer _departmentApiConsumer;

        public DepartmentApiManager(
            IMapper mapper,
            IDepartmentApiConsumer departmentApiConsumer
        ) {
            _mapper = mapper;
            _departmentApiConsumer = departmentApiConsumer;
        }

        public async Task<IResult> AddAsync(DepartmentCreateDto department)
        {
            await _departmentApiConsumer.Add(_mapper.Map<Department>(department));
            return new SuccessResult();
        }

        public async Task<IResult> UpdateAsync(DepartmentUpdateDto department)
        {
            await _departmentApiConsumer.Update(_mapper.Map<Department>(department));
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int departmentId)
        {
            await _departmentApiConsumer.Delete(departmentId);
            return new SuccessResult();
        }

        public async Task<IDataResult<DepartmentDto>> GetAsync(int departmentId)
            => new SuccessDataResult<DepartmentDto>(
                _mapper.Map<DepartmentDto>(
                    await _departmentApiConsumer.Get(departmentId)));

        public async Task<IDataResult<DepartmentDetailDto>> GetWithDetailsAsync(int departmentId)
            => new SuccessDataResult<DepartmentDetailDto>(
                _mapper.Map<DepartmentDetailDto>(
                    await _departmentApiConsumer.GetWithDetails(departmentId)));

        public async Task<IDataResult<IEnumerable<DepartmentDto>>> GetAllAsync()
            => new SuccessDataResult<IEnumerable<DepartmentDto>>(
                _mapper.Map<IEnumerable<DepartmentDto>>(
                    await _departmentApiConsumer.GetAll()));

        public async Task<IDataResult<IEnumerable<DepartmentDetailDto>>> GetAllWithDetailsAsync()
            => new SuccessDataResult<IEnumerable<DepartmentDetailDto>>(
                _mapper.Map<IEnumerable<DepartmentDetailDto>>(
                    await _departmentApiConsumer.GetAllWithDetails()));
    }
}
