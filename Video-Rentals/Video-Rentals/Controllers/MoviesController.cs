using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Video_Rentals.Models;
using Video_Rentals.ViewModels;
using System.Data.Entity;
using Video_Rentals.Migrations;



namespace Video_Rentals.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public ActionResult New()
        {
            var genre = _context.Genres.ToList();
            var viewmodel = new MovieFormViewModel
            {
                
                Genre = genre
            };
            return View("MovieForm",viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new MovieFormViewModel(movie)
                {
                    Genre = _context.Genres.ToList()
                };

                return View("MovieForm",viewmodel);
            }

            if(movie.Id==0)

            _context.Movies.Add(movie);

            else
            {
                var movieInDB = _context.Movies.SingleOrDefault(m => m.Id == movie.Id);

                movieInDB.Name = movie.Name;
                movieInDB.NumeberOfStock = movie.NumeberOfStock;
                movieInDB.ReaslesDate = movie.ReaslesDate;
                movieInDB.GenreId = movie.GenreId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index","Movies");
        }
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)

                return HttpNotFound();

            var veiwmodel = new MovieFormViewModel(movie)
            {
               
               Genre = _context.Genres.ToList()
            };

            return View("MovieForm", veiwmodel);
        }

        // GET: Movies

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }
        public ActionResult Details( int id) {

            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)

                return HttpNotFound();

            return View(movie);
        }
    }
}