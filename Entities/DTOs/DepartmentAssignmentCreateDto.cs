using Core.Entities;

namespace Entities.DTOs
{
    public class DepartmentAssignmentCreateDto : IDto
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
    }
}
