using System;
using System.ComponentModel.DataAnnotations;

namespace Movie_Renta_Web_App.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public int Stock { get; set; }

        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
    }
}