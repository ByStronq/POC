using Core.Entities;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class DepartmentDetailDto : DepartmentDto, IDto
    {
        public Department ParentDepartment { get; set; }
        public ICollection<Department> SubDepartments { get; set; }
        public ICollection<DepartmentAssignment> Assignments { get; set; }
    }
}
