using Core.Entities;

namespace Entities.Concrete
{
    public class DepartmentAssingment : IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
    }
}
