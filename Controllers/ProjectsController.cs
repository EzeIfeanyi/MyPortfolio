using Microsoft.AspNetCore.Mvc;
using MVCProjectPractice.Data;
using MVCProjectPractice.Models;

namespace MVCProjectPractice.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly DataService _context;

        public ProjectsController(DataService context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(new ProjectViewModel(_context));
        }
    }
}
