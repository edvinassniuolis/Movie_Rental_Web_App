using Movie_Renta_Web_App.Models;
using Movie_Renta_Web_App.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Movie_Renta_Web_App.Controllers
{
    public class MoviesController : Controller
    {
        private List<Movie> movies = new List<Movie>
        {
            new Movie() { Id = 1, Name = "Cassablanca"},
            new Movie() { Id = 2, Name = "Cars"}
    };

        public ActionResult Index()
        {

            var moviesViewModel = new IndexMovieModel { Movies = movies };

            return View(moviesViewModel);
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            var movie = movies.FirstOrDefault((m) => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
    }
}