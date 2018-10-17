using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Video_Rentals.Models;
using System.Data.Entity;

namespace Video_Rentals.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }
        public Movie Movie { get; set; }
    }
}