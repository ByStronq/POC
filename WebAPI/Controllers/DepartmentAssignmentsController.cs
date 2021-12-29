using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]"), ApiController]
    public class DepartmentAssignmentsController : ControllerBase
    {
        private readonly IDepartmentAssignmentService _departmentAssignmentService;

        public DepartmentAssignmentsController(
            IDepartmentAssignmentService departmentAssignmentService
        ) {
            _departmentAssignmentService = departmentAssignmentService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(DepartmentAssignmentCreateDto departmentAssignment)
        {
            var result = await _departmentAssignmentService.AddAsync(departmentAssignment);

            if (result != null && result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(DepartmentAssignmentUpdateDto departmentAssignment)
        {
            var result = await _departmentAssignmentService.UpdateAsync(departmentAssignment);

            if (result != null && result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("{departmentAssignmentId}")]
        public async Task<IActionResult> Delete(int departmentAssignmentId)
        {
            var result = await _departmentAssignmentService.DeleteAsync(departmentAssignmentId);

            if (result != null && result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("{departmentAssignmentId}")]
        public async Task<IActionResult> Get(int departmentAssignmentId)
        {
            var result = await _departmentAssignmentService.GetAsync(departmentAssignmentId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet, Route("api/[controller]/GetWithDetails/{departmentAssignmentId}")]
        public async Task<IActionResult> GetWithDetails(int departmentAssignmentId)
        {
            var result = await _departmentAssignmentService.GetWithDetailsAsync(departmentAssignmentId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _departmentAssignmentService.GetAllAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWithDetails()
        {
            var result = await _departmentAssignmentService.GetAllWithDetailsAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
