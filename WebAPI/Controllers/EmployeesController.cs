using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]"), ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(
            IEmployeeService employeeService
        ) {
            _employeeService = employeeService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeCreateDto employee)
        {
            var result = await _employeeService.AddAsync(employee);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(EmployeeUpdateDto employee)
        {
            var result = await _employeeService.UpdateAsync(employee);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int employeeId)
        {
            var result = await _employeeService.DeleteAsync(employeeId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int employeeId)
        {
            var result = await _employeeService.GetAsync(employeeId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetWithDetails(int employeeId)
        {
            var result = await _employeeService.GetWithDetailsAsync(employeeId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _employeeService.GetAllAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWithDetails()
        {
            var result = await _employeeService.GetAllWithDetailsAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
