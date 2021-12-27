using Core.Entities;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class EmployeeDto : EmployeeUpdateDto, IDto
    {
        public DateTime CreatedTime { get; set; }
    }
}
