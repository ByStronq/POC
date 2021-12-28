using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index() => View();
    }
}
