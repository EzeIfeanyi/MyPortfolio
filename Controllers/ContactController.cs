using Microsoft.AspNetCore.Mvc;
using MVCProjectPractice.Models;

namespace MVCProjectPractice.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(EmailViewModel model)
        {
            var message = model.Fullname + ";" + model.Email + ";" + model.PhoneNumber + ";" + model.Message;
            var result = Email.Send("Email from Portfolio", message, null);

            if (string.IsNullOrEmpty(result))
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
