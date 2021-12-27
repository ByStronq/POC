using Core.Entities;

namespace Entities.DTOs
{
    public class EmployeeDto : EmployeeUpdateDto, IDto
    {
        public DateTime CreatedTime { get; set; }
    }
}
