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

        public IResult Update(DepartmentUpdateDto department)
        {
            _departmentDal.Update(_mapper.Map<Department>(department));
            return new SuccessResult();
        }

        public IResult Delete(int departmentId)
        {
            _departmentDal.Delete(new Department { Id = departmentId });
            return new SuccessResult();
        }

        public IDataResult<DepartmentDto> Get(int departmentId)
            => new SuccessDataResult<DepartmentDto>(
                _mapper.Map<DepartmentDto>(
                    _departmentDal.Get(
                        department => department.Id == departmentId)));

        public IDataResult<DepartmentDetailDto> GetWithDetails(int departmentId)
            => new SuccessDataResult<DepartmentDetailDto>(
                _mapper.Map<DepartmentDetailDto>(
                    _departmentDal.GetWithDetails(
                        department => department.Id == departmentId)));

        public IDataResult<IEnumerable<DepartmentDto>> GetAll()
            => new SuccessDataResult<IEnumerable<DepartmentDto>>(
                _mapper.Map<IEnumerable<DepartmentDto>>(
                    _departmentDal.GetAll()));

        public IDataResult<IEnumerable<DepartmentDetailDto>> GetAllWithDetails()
            => new SuccessDataResult<IEnumerable<DepartmentDetailDto>>(
                _mapper.Map<IEnumerable<DepartmentDetailDto>>(
                    _departmentDal.GetAllWithDetails()));
    }
}
