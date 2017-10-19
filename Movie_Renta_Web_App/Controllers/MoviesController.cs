using Movie_Renta_Web_App.Models;
using Movie_Renta_Web_App.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Movie_Renta_Web_App.Controllers
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
            _context.Dispose();
        }

        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");
            return View("ReadOnlyList");
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).FirstOrDefault((m) => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {

            var movies = _context.Movies.Include(m => m.Genre).ToList();

            var movieViewModel = new NewMovieViewModel
            {
                Movie = new Movie() { Stock = 0 },
                GenreTypes = _context.Genres.ToList()
            };
            return View("New", movieViewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var moviesView = new NewMovieViewModel
                {
                    Movie = movie,
                    GenreTypes = _context.Genres.ToList()
                };
                return View("New", moviesView);
            }
            _context.Movies.Add(movie);

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var movieViewModel = new NewMovieViewModel
            {
                Movie = movie,
                GenreTypes = _context.Genres.ToList()
            };
            return View("Edit", movieViewModel);
        }

        [HttpPost]
        public ActionResult Update(Movie movie)
        {
            var movieFromDB = _context.Movies.Single(m => m.Id == movie.Id);

            movieFromDB.Name = movie.Name;
            movieFromDB.DateAdded = movie.DateAdded;
            movieFromDB.GenreId = movie.GenreId;
            movieFromDB.ReleaseDate = movie.ReleaseDate;
            movieFromDB.Stock = movie.Stock;

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}