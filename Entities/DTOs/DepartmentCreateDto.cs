using Core.Entities;

namespace Entities.DTOs
{
    public class DepartmentCreateDto : IDto
    {
        public string Name { get; set; }
        public int? DepartmentId { get; set; }
    }
}
