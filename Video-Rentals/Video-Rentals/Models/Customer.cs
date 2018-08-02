using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Video_Rentals.Models;

namespace Video_Rentals.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubcribedToNewsLetter { get; set; }
    }
}