namespace Y13TPIWebproject.Models
{
    public class Checkout
    {
        public int CheckoutID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public ICollection<Product_Checkout> Product_Checkouts { get; set; }
    }
}
