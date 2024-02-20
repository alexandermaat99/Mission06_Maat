using Microsoft.AspNetCore.Mvc;
using Mission06_Maat.Models;
using System.Diagnostics;

namespace Mission06_Maat.Controllers
{
    public class HomeController : Controller
    {

        private MovieApplicationContext _context; // field

        public HomeController(MovieApplicationContext temp) // constructor 
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult movieCollection()
        {
            return View();
        }


        [HttpPost]
        public IActionResult movieCollection(Application response)
        {
            _context.Application.Add(response); // adds record to the database
            _context.SaveChanges(); // saves changes to the database
            return View("Confirmation", response);
        }
    }
}
