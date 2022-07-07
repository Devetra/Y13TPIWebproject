namespace Y13TPIWebproject.Models
{
    public class Product_Checkout
    {
        public int Product_CheckoutID { get; set; }

        public Product ProductID { get; set; }
        public Checkout CheckoutID { get; set; }
    }
}
