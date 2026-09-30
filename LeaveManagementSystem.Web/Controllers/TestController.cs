using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Guilherme",
                DateOfBirth = new DateTime(2001, 05, 10)
            };
            return View(data);
        }
    }
}
