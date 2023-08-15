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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var message = "Message From: " + model.Fullname + "/n/r" + "Sender Email: " 
                + model.Email + "/n/r" + "Content: " + model.Message;

            var result = Email.Send("Email from Portfolio", message);

            if (string.IsNullOrEmpty(result))
            {
                TempData["success"] = "Email sent successfully";
                return RedirectToAction("Index");
            }
            TempData["failure"] = "Unable to send email to recipient";
            return View();
        }
    }
}
