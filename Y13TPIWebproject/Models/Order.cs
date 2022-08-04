﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Y13TPIWebproject.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int CheckoutID { get; set; }

        public Customer Customer { get; set; }
        public Checkout Checkout { get; set; }

        
    }
}
