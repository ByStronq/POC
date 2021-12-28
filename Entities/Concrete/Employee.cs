using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        [Required, MaxLength(26)] public string RegistrationNumber { get; set; }
        [Required, MaxLength(256)] public string Name { get; set; }
        [Required, MaxLength(256)] public string Surname { get; set; }
        public int? DepartmentId { get; set; }
        public virtual ICollection<DepartmentAssignment> DepartmentAssingments { get; set; }
        [Required] public DateTime CreatedTime { get; set; } = DateTime.Now;
        [Required] public bool IsActive { get; set; } = true;
    }
}
