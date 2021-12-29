using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Department : IEntity
    {
        public int Id { get; set; }
        [Required, MaxLength(256)] public string Name { get; set; }
        public int? DepartmentId { get; set; }
        public virtual Department ParentDepartment { get; set; }
        public virtual ICollection<Department> SubDepartments { get; set; }
        public virtual ICollection<DepartmentAssignment> Assignments { get; set; }
        [Required] public DateTime CreatedTime { get; set; } = DateTime.Now;
        [Required] public bool IsActive { get; set; } = true;
    }
}
