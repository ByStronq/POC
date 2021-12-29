﻿using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entities.Concrete
{
    public class Department : IEntity
    {
        public int Id { get; set; }
        [Required, MaxLength(256)] public string Name { get; set; }
        public int? DepartmentId { get; set; }
        [JsonIgnore] public virtual Department ParentDepartment { get; set; }
        [JsonIgnore] public virtual ICollection<Department> SubDepartments { get; set; }
        [Required] public DateTime CreatedTime { get; set; } = DateTime.Now;
        [Required] public bool IsActive { get; set; } = true;
    }
}
