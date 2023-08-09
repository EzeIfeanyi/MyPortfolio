using Microsoft.AspNetCore.Mvc;

namespace MVCProjectPractice.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
