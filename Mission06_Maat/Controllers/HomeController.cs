using Microsoft.AspNetCore.Mvc;
using Mission06_Maat.Data;
using Mission06_Maat.Models; // Make sure this namespace contains the updated Movie and Category models
using System.Linq;

namespace Mission06_Maat.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext _context; // Assuming MovieApplicationContext is updated for new database

        public HomeController(MovieApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieCollection()
        {
            ViewBag.Categories = _context.Categories.ToList(); // Assuming Categories are to be displayed in the form
            return View(new Movie()); // Passing a new Movie object to the view
        }

        [HttpPost]
        public IActionResult MovieCollection(Movie movie)
        {
            if (ModelState.IsValid) // Checking if the model state is valid
            {
                _context.Movies.Add(movie); // Adds record to the database
                _context.SaveChanges(); // Saves changes to the database

                return View("Confirmation", movie); // Redirecting to the Confirmation view with the movie object
            }

            ViewBag.Categories = _context.Categories.ToList(); // Repopulate Categories in case of an invalid model state
            return View(movie); // Return the view with the current movie object
        }

        public IActionResult MovieListView()
        {
            var movies = _context.Movies.OrderBy(x => x.MovieId).ToList(); // Fetching movies ordered by MovieId
            return View(movies); // Passing the movies list to the view
        }
    }
}
