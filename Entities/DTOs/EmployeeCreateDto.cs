using Core.Entities;

namespace Entities.DTOs
{
    public class EmployeeCreateDto : IDto
    {
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? DepartmentId { get; set; }
    }
}
