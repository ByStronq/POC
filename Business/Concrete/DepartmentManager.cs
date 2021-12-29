using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentDal _departmentDal;

        public DepartmentManager(
            IMapper mapper,
            IDepartmentDal departmentDal
        ) {
            _mapper = mapper;
            _departmentDal = departmentDal;
        }

        public IResult Add(DepartmentCreateDto department)
        {
            _departmentDal.Add(_mapper.Map<Department>(department));
            return new SuccessResult();
        }

        public async Task<IResult?> AddAsync(DepartmentCreateDto department)
        {
            await _departmentDal.AddAsync(_mapper.Map<Department>(department));
            return new SuccessResult();
        }

        public IResult Update(DepartmentUpdateDto department)
        {
            _departmentDal.Update(_mapper.Map<Department>(department));
            return new SuccessResult();
        }

        public async Task<IResult?> UpdateAsync(DepartmentUpdateDto department)
        {
            await _departmentDal.UpdateAsync(_mapper.Map<Department>(department));
            return new SuccessResult();
        }

        public IResult Delete(int departmentId)
        {
            _departmentDal.Delete(new Department { Id = departmentId });
            return new SuccessResult();
        }

        public async Task<IResult?> DeleteAsync(int departmentId)
        {
            await _departmentDal.DeleteAsync(new Department { Id = departmentId });
            return new SuccessResult();
        }

        public IDataResult<DepartmentDto> Get(int departmentId)
            => new SuccessDataResult<DepartmentDto>(
                _mapper.Map<DepartmentDto>(
                    _departmentDal.Get(
                        department => department.Id == departmentId)));

        public async Task<IDataResult<DepartmentDto>> GetAsync(int departmentId)
            => new SuccessDataResult<DepartmentDto>(
                _mapper.Map<DepartmentDto>(
                    await _departmentDal.GetAsync(
                        department => department.Id == departmentId)));

        public IDataResult<DepartmentDetailDto> GetWithDetails(int departmentId)
            => new SuccessDataResult<DepartmentDetailDto>(
                _mapper.Map<DepartmentDetailDto>(
                    _departmentDal.GetWithDetails(
                        department => department.Id == departmentId)));

        public async Task<IDataResult<DepartmentDetailDto>> GetWithDetailsAsync(int departmentId)
            => new SuccessDataResult<DepartmentDetailDto>(
                _mapper.Map<DepartmentDetailDto>(
                    await _departmentDal.GetWithDetailsAsync(
                        department => department.Id == departmentId)));

        public IDataResult<IEnumerable<DepartmentDto>> GetAll()
            => new SuccessDataResult<IEnumerable<DepartmentDto>>(
                _mapper.Map<IEnumerable<DepartmentDto>>(
                    _departmentDal.GetAll()));

        public async Task<IDataResult<IEnumerable<DepartmentDto>>> GetAllAsync()
            => new SuccessDataResult<IEnumerable<DepartmentDto>>(
                _mapper.Map<IEnumerable<DepartmentDto>>(
                    await _departmentDal.GetAllAsync()));

        public IDataResult<IEnumerable<DepartmentDetailDto>> GetAllWithDetails()
            => new SuccessDataResult<IEnumerable<DepartmentDetailDto>>(
                _mapper.Map<IEnumerable<DepartmentDetailDto>>(
                    _departmentDal.GetAllWithDetails()));

        public async Task<IDataResult<IEnumerable<DepartmentDetailDto>>> GetAllWithDetailsAsync()
            => new SuccessDataResult<IEnumerable<DepartmentDetailDto>>(
                _mapper.Map<IEnumerable<DepartmentDetailDto>>(
                    await _departmentDal.GetAllWithDetailsAsync()));
    }
}
