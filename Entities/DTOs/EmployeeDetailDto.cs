using Core.Entities;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class EmployeeDetailDto : EmployeeDto, IDto
    {
        public ICollection<DepartmentAssignment> DepartmentAssingments { get; set; }
    }
}
