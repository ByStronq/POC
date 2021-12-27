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
        public virtual ICollection<DepartmentAssignment> DepartmentAssingments { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
