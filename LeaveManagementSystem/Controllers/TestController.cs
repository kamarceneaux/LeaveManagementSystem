using LeaveManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of MVC Masterssy",
                DateOfBirth = new DateTime(1954, 12, 01)
            };
            return View(data);
        }

    }
}
