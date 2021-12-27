using Core.Entities;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class EmployeeDetailDto : EmployeeDto, IDto
    {
        public Department Department { get; set; }
    }
}
