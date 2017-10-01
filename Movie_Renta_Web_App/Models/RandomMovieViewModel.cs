using System.Collections.Generic;

namespace Movie_Renta_Web_App.Models
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}