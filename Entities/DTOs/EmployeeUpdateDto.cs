using Core.Entities;

namespace Entities.DTOs
{
    public class EmployeeUpdateDto : EmployeeCreateDto, IDto
    {
        public int Id { get; set; }
    }
}
