using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Y13TPIWebproject.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }

        public string StreetNumber { get; set; }

        public string StreetName { get; set; }

        public string Surburb { get; set; }

        public string City { get; set; }


        public ICollection<Order> Orders { get; set; }

    }
}
