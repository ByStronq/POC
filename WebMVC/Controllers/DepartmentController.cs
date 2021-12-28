using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentApiService _departmentApiService;
        private readonly IDepartmentAssignmentApiService _departmentAssignmentApiService;

        public DepartmentController(
            IDepartmentApiService departmentApiService,
            IDepartmentAssignmentApiService departmentAssignmentApiService
        ) {
            _departmentApiService = departmentApiService;
            _departmentAssignmentApiService = departmentAssignmentApiService;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> AddDepartment(DepartmentCreateDto department)
        {
            var result = await _departmentApiService.AddAsync(department);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDepartment(DepartmentUpdateDto department)
        {
            var result = await _departmentApiService.UpdateAsync(department);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("{departmentId}")]
        public async Task<IActionResult> DeleteDepartment(int departmentId)
        {
            var result = await _departmentApiService.DeleteAsync(departmentId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("{departmentId}")]
        public async Task<IActionResult> GetDepartment(int departmentId)
        {
            var result = await _departmentApiService.GetAsync(departmentId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet, Route("api/[controller]/GetDepartmentWithDetails/{departmentId}")]
        public async Task<IActionResult> GetDepartmentWithDetails(int departmentId)
        {
            var result = await _departmentApiService.GetWithDetailsAsync(departmentId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            var result = await _departmentApiService.GetAllAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartmentsWithDetails()
        {
            var result = await _departmentApiService.GetAllWithDetailsAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddDepartmentAssignment(DepartmentAssignmentCreateDto departmentAssignment)
        {
            var result = await _departmentAssignmentApiService.AddAsync(departmentAssignment);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDepartmentAssignment(DepartmentAssignmentUpdateDto departmentAssignment)
        {
            var result = await _departmentAssignmentApiService.UpdateAsync(departmentAssignment);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("{departmentAssignmentId}")]
        public async Task<IActionResult> DeleteDepartmentAssignment(int departmentAssignmentId)
        {
            var result = await _departmentAssignmentApiService.DeleteAsync(departmentAssignmentId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("{departmentAssignmentId}")]
        public async Task<IActionResult> GetDepartmentAssignment(int departmentAssignmentId)
        {
            var result = await _departmentAssignmentApiService.GetAsync(departmentAssignmentId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet, Route("api/[controller]/GetDepartmentAssignmentWithDetails/{departmentAssignmentId}")]
        public async Task<IActionResult> GetDepartmentAssignmentWithDetails(int departmentAssignmentId)
        {
            var result = await _departmentAssignmentApiService.GetWithDetailsAsync(departmentAssignmentId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartmentAssignments()
        {
            var result = await _departmentAssignmentApiService.GetAllAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartmentAssignmentsWithDetails()
        {
            var result = await _departmentAssignmentApiService.GetAllWithDetailsAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
