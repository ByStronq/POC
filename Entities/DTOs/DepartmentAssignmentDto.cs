using Core.Entities;

namespace Entities.DTOs
{
    public class DepartmentAssignmentDto : DepartmentAssignmentUpdateDto, IDto
    {
        public DateTime CreatedTime { get; set; }
    }
}
