using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Video_Rentals.Models;

namespace Video_Rentals.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }

        
        [Display(Name = "Genre Type")]
        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Reasles Date")]
        public DateTime ReaslesDate { get; set; }

        [Display(Name ="Number of Stock")]
        public byte NumeberOfStock { get; set; }


    }
}