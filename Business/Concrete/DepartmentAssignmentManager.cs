using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class DepartmentAssignmentManager : IDepartmentAssignmentService
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentAssignmentDal _departmentAssignmentDal;

        public DepartmentAssignmentManager(
            IMapper mapper,
            IDepartmentAssignmentDal departmentAssignmentDal
        ) {
            _mapper = mapper;
            _departmentAssignmentDal = departmentAssignmentDal;
        }

        public IResult Add(DepartmentAssignmentCreateDto departmentAssignment)
        {
            _departmentAssignmentDal.Add(_mapper.Map<DepartmentAssignment>(departmentAssignment));
            return new SuccessResult();
        }

        public async Task<IResult> AddAsync(DepartmentAssignmentCreateDto departmentAssignment)
        {
            await _departmentAssignmentDal.AddAsync(_mapper.Map<DepartmentAssignment>(departmentAssignment));
            return new SuccessResult();
        }

        public IResult Update(DepartmentAssignmentUpdateDto departmentAssignment)
        {
            _departmentAssignmentDal.Update(_mapper.Map<DepartmentAssignment>(departmentAssignment));
            return new SuccessResult();
        }

        public async Task<IResult> UpdateAsync(DepartmentAssignmentUpdateDto departmentAssignment)
        {
            await _departmentAssignmentDal.UpdateAsync(_mapper.Map<DepartmentAssignment>(departmentAssignment));
            return new SuccessResult();
        }

        public IResult Delete(int departmentAssignmentId)
        {
            _departmentAssignmentDal.Delete(new DepartmentAssignment { Id = departmentAssignmentId });
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int departmentAssignmentId)
        {
            await _departmentAssignmentDal.DeleteAsync(new DepartmentAssignment { Id = departmentAssignmentId });
            return new SuccessResult();
        }

        public IDataResult<DepartmentAssignmentDto> Get(int departmentAssignmentId)
            => new SuccessDataResult<DepartmentAssignmentDto>(
                _mapper.Map<DepartmentAssignmentDto>(
                    _departmentAssignmentDal.Get(
                        departmentAssignment => departmentAssignment.Id == departmentAssignmentId)));

        public async Task<IDataResult<DepartmentAssignmentDto>> GetAsync(int departmentAssignmentId)
            => new SuccessDataResult<DepartmentAssignmentDto>(
                _mapper.Map<DepartmentAssignmentDto>(
                    await _departmentAssignmentDal.GetAsync(
                        departmentAssignment => departmentAssignment.Id == departmentAssignmentId)));

        public IDataResult<DepartmentAssignmentDetailDto> GetWithDetails(int departmentAssignmentId)
            => new SuccessDataResult<DepartmentAssignmentDetailDto>(
                _mapper.Map<DepartmentAssignmentDetailDto>(
                    _departmentAssignmentDal.GetWithDetails(
                        departmentAssignment => departmentAssignment.Id == departmentAssignmentId)));

        public async Task<IDataResult<DepartmentAssignmentDetailDto>> GetWithDetailsAsync(int departmentAssignmentId)
            => new SuccessDataResult<DepartmentAssignmentDetailDto>(
                _mapper.Map<DepartmentAssignmentDetailDto>(
                    await _departmentAssignmentDal.GetWithDetailsAsync(
                        departmentAssignment => departmentAssignment.Id == departmentAssignmentId)));

        public IDataResult<IEnumerable<DepartmentAssignmentDto>> GetAll()
            => new SuccessDataResult<IEnumerable<DepartmentAssignmentDto>>(
                _mapper.Map<IEnumerable<DepartmentAssignmentDto>>(
                    _departmentAssignmentDal.GetAll()));

        public async Task<IDataResult<IEnumerable<DepartmentAssignmentDto>>> GetAllAsync()
            => new SuccessDataResult<IEnumerable<DepartmentAssignmentDto>>(
                _mapper.Map<IEnumerable<DepartmentAssignmentDto>>(
                    await _departmentAssignmentDal.GetAllAsync()));

        public IDataResult<IEnumerable<DepartmentAssignmentDetailDto>> GetAllWithDetails()
            => new SuccessDataResult<IEnumerable<DepartmentAssignmentDetailDto>>(
                _mapper.Map<IEnumerable<DepartmentAssignmentDetailDto>>(
                    _departmentAssignmentDal.GetAllWithDetails()));

        public async Task<IDataResult<IEnumerable<DepartmentAssignmentDetailDto>>> GetAllWithDetailsAsync()
            => new SuccessDataResult<IEnumerable<DepartmentAssignmentDetailDto>>(
                _mapper.Map<IEnumerable<DepartmentAssignmentDetailDto>>(
                    await _departmentAssignmentDal.GetAllWithDetailsAsync()));
    }
}
