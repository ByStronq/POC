using Core.Entities;

namespace Entities.DTOs
{
    public class DepartmentAssignmentUpdateDto : DepartmentAssignmentCreateDto, IDto
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
