using Microsoft.AspNetCore.Mvc;
using LabTaskOne.Models;

namespace LabTaskOne.Controllers
{
    public class JobController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Job());
        }
        [HttpPost]
        public IActionResult Index(Job jb)
        {
            if (ModelState.IsValid) {
                return View(jb);

            }
            return View();
        }
        [HttpGet]
        public ActionResult Details(string fuuName, string email, string position, int experience, int salary) {
            ViewBag.fuuName = fuuName;
            ViewBag.email = email;
            ViewBag.position = position;
            ViewBag.experience = experience;
            ViewBag.expectedSalary = salary;
            return View();
        }
    }
}
