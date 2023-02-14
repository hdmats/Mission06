using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieDatabaseContext _MovieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieDatabaseContext someName)
        {
            _logger = logger;
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
            return View();
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
                return View("Movies");
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
