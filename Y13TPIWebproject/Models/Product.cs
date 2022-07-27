namespace Y13TPIWebproject.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Product(string productName)
        {
            ProductName = productName;
        }
        public decimal Price { get; set; }

        public ICollection<Product_Checkout> Product_Checkouts { get; set; }
    }
}
