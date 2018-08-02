using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Video_Rentals.Models;

namespace Video_Rentals.ViewModels
{
    public class RandomMovieViewModels
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}