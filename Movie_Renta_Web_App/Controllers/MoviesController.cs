using Movie_Renta_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Movie_Renta_Web_App.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Id = 2, Name = "CARS"};
            var customers = new List<Customer>
            {
                new Customer() { Id = 1, Name = "alex"},
                new Customer() {Id = 2, Name = "Sabina"}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        [Route("movies/released/{year:regex(\\d{4}}/{month:regex(\\d{2}:range(1, 12))}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}