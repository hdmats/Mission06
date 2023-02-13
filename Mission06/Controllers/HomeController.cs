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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Movies(MoviesModel m)
        {
            if (ModelState.IsValid)
            {
                _MovieContext.Add(m);
                _MovieContext.SaveChanges();
                return View("Confirmation", m);
            }
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
