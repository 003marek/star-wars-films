using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarWarsFilms.Models;
using StarWarsFilms.Database;

namespace StarWarsFilms.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static IEnumerable<FilmViewModel> Films { get; set; }
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _logger = logger;
            _context = dataContext;
        }

        public IActionResult Index()
        {
            if (Films == null || !Films.Any())
                Films = new SwapiClient(_logger).GetFilmsAsync().Result;
            return View(Films);
        }

        public IActionResult Details(int id)
        {
            var film = Films.FirstOrDefault(o => o.EpisodeId == id);
            var ratings = _context.Ratings?.Where(x => x.EpisodeId == id)?.Select(x => new RatingViewModel()
            {
                EpisodeId = x.EpisodeId,
                FilmRating = x.FilmRating,
                Title = film.Title,
                Username = x.Username,
                Id = x.Id
            })?.ToList();
            return View(new FilmDetailsViewModel() { Film = film, Ratings = ratings});
        }

        public IActionResult Rate(int id)
        {
            var film = Films.FirstOrDefault(o => o.EpisodeId == id);
            return View(new RatingViewModel() { Title = film.Title, EpisodeId = film.EpisodeId });
        }

        [HttpPost]
        public async Task<ActionResult> Rate(RatingViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Ratings.Add(new RatingEntity
            {
                EpisodeId = model.EpisodeId,
                FilmRating = model.FilmRating,
                Username = model.Username
            });
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", new { id = model.EpisodeId });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
