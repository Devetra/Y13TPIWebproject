using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Y13TPIWebproject.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }
        public string Description { get; set; }

        public int Quantity { get; set; }




    }
}
