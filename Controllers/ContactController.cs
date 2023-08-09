using Microsoft.AspNetCore.Mvc;

namespace MVCProjectPractice.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
