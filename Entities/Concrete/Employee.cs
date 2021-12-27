using Core.Entities;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
