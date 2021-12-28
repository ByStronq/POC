using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class DepartmentAssignment : IEntity
    {
        public int Id { get; set; }
        [Required] public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        [Required] public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        [Required] public DateTime CreatedTime { get; set; } = DateTime.Now;
        [Required] public bool IsDeleted { get; set; }
    }
}
