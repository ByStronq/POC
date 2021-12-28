using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Mappings.AutoMapper
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Employee, EmployeeCreateDto>().ReverseMap();
            CreateMap<Employee, EmployeeUpdateDto>().ReverseMap();
            CreateMap<Employee, EmployeeDetailDto>().ReverseMap();

            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<Department, DepartmentCreateDto>().ReverseMap();
            CreateMap<Department, DepartmentUpdateDto>().ReverseMap();
            CreateMap<Department, DepartmentDetailDto>().ReverseMap();

            CreateMap<DepartmentAssignment, DepartmentAssignmentDto>().ReverseMap();
            CreateMap<DepartmentAssignment, DepartmentAssignmentCreateDto>().ReverseMap();
            CreateMap<DepartmentAssignment, DepartmentAssignmentUpdateDto>().ReverseMap();
            CreateMap<DepartmentAssignment, DepartmentAssignmentDetailDto>().ReverseMap();
        }
    }
}
