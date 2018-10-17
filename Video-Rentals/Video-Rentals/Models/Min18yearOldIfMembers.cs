using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Video_Rentals.Models
{
    public class Min18yearOldIfMembers:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId== MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)

                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthday is requried");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age > 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should may at least 18 years old");

        }
    }
}