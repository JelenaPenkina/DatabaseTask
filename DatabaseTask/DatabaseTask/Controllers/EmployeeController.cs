using Microsoft.AspNetCore.Mvc;

namespace DatabaseTask.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
