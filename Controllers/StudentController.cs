using Microsoft.AspNetCore.Mvc;

namespace ChavezMA1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddStudent()
        {
            return View();
        }
    }
}
