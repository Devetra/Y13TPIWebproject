using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Y13TPIWebproject.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public int CustomerID { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
