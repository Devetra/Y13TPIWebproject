using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Y13TPIWebproject.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string Street { get; set; }
        public string Suburb { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int Zip { get; set; }
    }
}
