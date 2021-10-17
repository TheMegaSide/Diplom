namespace FInalProject.Models
{
    public class ProductResponseModel
    {
        public Product Products { get; set; }
        public Category Category { get; set; }
        public Seller Seller { get; set; }
        public Stock Stock { get; set; }
    }
}