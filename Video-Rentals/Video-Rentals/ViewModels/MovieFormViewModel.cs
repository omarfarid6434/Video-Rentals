using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Video_Rentals.Models;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Video_Rentals.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }
        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }



        [Display(Name = "Genre Type")]

        public byte? GenreId { get; set; }


        [Display(Name = "Reasles Date")]
        [Required]
        public DateTime? ReaslesDate { get; set; }

        [Display(Name = "Number of Stock")]
        [Range(1, 20)]
        [Required]
        public byte? NumeberOfStock { get; set; }

        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Edit Movie";
                return "New Movie";
            }
        }


        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReaslesDate = movie.ReaslesDate;
            NumeberOfStock = movie.NumeberOfStock;
            GenreId = movie.GenreId;
        }
    }
}