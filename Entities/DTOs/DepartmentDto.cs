using Core.Entities;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class DepartmentDto : DepartmentUpdateDto, IDto
    {
        public DateTime CreatedTime { get; set; }
    }
}
