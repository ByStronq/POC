using Core.Entities;

namespace Entities.DTOs
{
    public class DepartmentDto : DepartmentUpdateDto, IDto
    {
        public DateTime CreatedTime { get; set; }
    }
}
