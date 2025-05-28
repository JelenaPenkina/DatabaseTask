using DatabaseTask.Data;
using DatabaseTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseTask.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly DatabaseTaskDbContext _context;

        public EmployeeController(DatabaseTaskDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Employee> employees;
            employees = _context.Employees.ToList();
            return View(employees);
        }
    }
}
