using Core.Entities;

namespace Entities.DTOs
{
    public class DepartmentUpdateDto : DepartmentCreateDto, IDto
    {
        public int Id { get; set; }
    }
}
