using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Y13TPIWebproject.Models
{
    public class Product_Checkout
    {
        public int Product_CheckoutID { get; set; }

        public Product ProductID { get; set; }
        public Checkout CheckoutID { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Checkout> Checkouts { get; set; }
    }
}
