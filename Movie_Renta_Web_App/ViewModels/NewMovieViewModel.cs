using Movie_Renta_Web_App.Models;
using System.Collections.Generic;

namespace Movie_Renta_Web_App.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> GenreTypes { get; set; }
        public Movie Movie { get; set; }
    }
}