using System;

namespace FInalProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductIndex { get; set; }
        public string ProductUnit { get; set; }
        public decimal CategoryId { get; set; }
        public decimal SellerId { get; set; }
        public decimal StockId { get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime ProductDate { get; set; }
        public decimal Amount { get; set; }
    }
}