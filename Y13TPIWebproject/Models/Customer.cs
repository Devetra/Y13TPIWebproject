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
        public int Phone { get; set; }
        [Required]
        public string Email { get; set; }
        public int AddressID { get; set; }

        public Address Address { get; set; }

        public ICollection<Order> Orders { get; set; }


    }
}
