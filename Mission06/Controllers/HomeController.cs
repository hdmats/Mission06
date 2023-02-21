using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06.Models;
using System.Linq;

namespace Mission06.Controllers
{
    public class HomeController : Controller
    {
        private MovieDatabaseContext _MovieContext { get; set; }

        public HomeController(MovieDatabaseContext someName)
        {
            _MovieContext = someName;
        }
        //sends user to indexpage on loading
        public IActionResult Index()
        {
            return View();
        }
        //sends user to podcast page
        public IActionResult Podcast()
        {
            return View();
        }

        //Get method
        [HttpGet]
        //Sends user to movies form page
        public IActionResult Movies()
        {
            ViewBag.Categories =  _MovieContext.Categories.ToList();

            return View(new MoviesModel());
        }
        //Post method
        [HttpPost]
        public IActionResult Movies(MoviesModel m)
        {
            //if foerm is valid adds form to database and sends user to confirmation page
            if (ModelState.IsValid)
            {
                _MovieContext.Add(m);
                _MovieContext.SaveChanges();
                return View("Confirmation", m);
            }
            //if form does not validate sends user back to the form
            else
            {
                ViewBag.Categories = _MovieContext.Categories.ToList();
                return View(m);
            }
        }

        public IActionResult viewMovies()
        {
            var movies = _MovieContext.Responses.Include(x => x.category).ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _MovieContext.Categories.ToList();

            var movie = _MovieContext.Responses.Single(x => x.ApplicationID == id);

            return View("Movies", movie);
        }
        [HttpPost]
        public IActionResult Edit(MoviesModel m)
        {
            _MovieContext.Update(m);
            _MovieContext.SaveChanges();
            return RedirectToAction("viewMovies"); 
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _MovieContext.Responses.Single(x => x.ApplicationID == id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(MoviesModel m)
        {
            _MovieContext.Responses.Remove(m);
            _MovieContext.SaveChanges();
            return RedirectToAction("viewMovies");
        }
    }
}
