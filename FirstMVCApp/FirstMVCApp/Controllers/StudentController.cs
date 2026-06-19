using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title = "Student List";
            ViewData["SubTitle"] = "Enrolled students this semster";

            var students = new List<string>
            {
                "Alice", "Bob", "Charlie"
            };
            return View(students);
        }

        public IActionResult Details(int id)
        {
            ViewBag.StudentId = id;
            return View();
        }

        public IActionResult About()
        {
            return Content("This is the student module.");
        }
    }
}