using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeApiService _employeeApiService;

        public EmployeeController(
            IEmployeeApiService employeeApiService
        ) {
            _employeeApiService = employeeApiService;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeCreateDto employee)
        {
            var result = await _employeeApiService.AddAsync(employee);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(EmployeeUpdateDto employee)
        {
            var result = await _employeeApiService.UpdateAsync(employee);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("{employeeId}")]
        public async Task<IActionResult> Delete(int employeeId)
        {
            var result = await _employeeApiService.DeleteAsync(employeeId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("{employeeId}")]
        public async Task<IActionResult> Get(int employeeId)
        {
            var result = await _employeeApiService.GetAsync(employeeId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("Details/{employeeId}")]
        public async Task<IActionResult> GetWithDetails(int employeeId)
        {
            var result = await _employeeApiService.GetWithDetailsAsync(employeeId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _employeeApiService.GetAllAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("AllWithDetails")]
        public async Task<IActionResult> GetAllWithDetails()
        {
            var result = await _employeeApiService.GetAllWithDetailsAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
