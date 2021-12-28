using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index() => View();
    }
}
