using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Video_Rentals.Models;

namespace Video_Rentals.Dtos
{
    public class CustomersDto
    {
        public int Id { get; set; }


        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubcribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }

        //[Min18yearOldIfMembers]
        public DateTime? Birthdate { get; set; }
    }
}