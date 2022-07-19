namespace Y13TPIWebproject.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }

        public Address(string street, string suburb, string city)
        {
            Street = street;
            Suburb = suburb;
            City = city;
        }
    }
}
