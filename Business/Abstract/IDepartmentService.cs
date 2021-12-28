using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        IResult Add(DepartmentCreateDto department);
        IResult Update(DepartmentUpdateDto department);
        IResult Delete(int departmentId);
        IDataResult<DepartmentDto> Get(int departmentId);
        IDataResult<DepartmentDetailDto> GetWithDetails(int departmentId);
        IDataResult<IEnumerable<DepartmentDto>> GetAll();
        IDataResult<IEnumerable<DepartmentDetailDto>> GetAllWithDetails();
    }
}
