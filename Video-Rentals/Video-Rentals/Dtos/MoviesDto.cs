using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Video_Rentals.Models;

namespace Video_Rentals.Dtos
{
    public class MoviesDto
    {

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public byte GenreId { get; set; }
        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReaslesDate { get; set; }

        [Range(1, 20)]
        public byte NumeberOfStock { get; set; }
    }
}