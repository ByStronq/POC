using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]"), ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentsController(
            IDepartmentService departmentService
        ) {
            _departmentService = departmentService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(DepartmentCreateDto department)
        {
            var result = await _departmentService.AddAsync(department);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(DepartmentUpdateDto department)
        {
            var result = await _departmentService.UpdateAsync(department);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int departmentId)
        {
            var result = await _departmentService.DeleteAsync(departmentId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int departmentId)
        {
            var result = await _departmentService.GetAsync(departmentId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetWithDetails(int departmentId)
        {
            var result = await _departmentService.GetWithDetailsAsync(departmentId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _departmentService.GetAllAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWithDetails()
        {
            var result = await _departmentService.GetAllWithDetailsAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
