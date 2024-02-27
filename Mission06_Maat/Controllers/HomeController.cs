using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Maat.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Mission06_Maat.Controllers
{
    public class HomeController : Controller
    {

        private AddMoviesContext _context;

        public HomeController(AddMoviesContext temp) //constructor
        {
            _context = temp;
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
        public IActionResult AddMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //add record to the database
                _context.SaveChanges();
                return View("Confirmation", response);
            }
            else //when something is invalid
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();
                return View(response);
            }

        }

        public IActionResult ViewMovie()
        {
            //Linq
            var movies = _context.Movies.Include("Category")
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            var editMovie = _context.Movies
                .Single(x => x.MovieId == id);
            ViewBag.Categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();
            return View("AddMovies", editMovie);
        }

        [HttpPost]
        public IActionResult Edit(Movie updateMovie)
        {
            _context.Update(updateMovie);
            _context.SaveChanges();

            return RedirectToAction("ViewMovie");
        }

    }
}