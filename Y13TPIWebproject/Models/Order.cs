using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Y13TPIWebproject.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        [Required]

        [Display(Name = "Quantity")]
        public int ProductQuantity{ get; set; }
    public Customer customer { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
