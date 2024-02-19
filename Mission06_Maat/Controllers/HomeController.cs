using Microsoft.AspNetCore.Mvc;
using Mission06_Maat.Models;
using System.Diagnostics;

namespace Mission06_Maat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) // constructor 
        {
            _logger = logger;
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
            return View("Confirmation", response);
        }
    }
}
