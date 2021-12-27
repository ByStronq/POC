using Core.Entities;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class DepartmentAssignmentDetailDto : DepartmentAssignmentDto, IDto
    {
        public Employee Employee { get; set; }
        public Department Department { get; set; }
    }
}
