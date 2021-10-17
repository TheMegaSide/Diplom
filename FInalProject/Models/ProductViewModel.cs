using System.Collections.Generic;

namespace FInalProject.Models
{
    public class ProductViewModel
    {
        public Product Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Seller> Sellers { get; set; }
        public IEnumerable<Stock> Stocks { get; set; }
        public int SellerResponse { get; set; }
        public int StockResponse { get; set; }
        public int CategoryResponse { get; set; }

        
    }
}