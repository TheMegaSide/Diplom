using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FInalProject.Models
{
    public class Order
    {
        public decimal OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Completion { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal ClientId { get; set; }
        public int id { get; set; }
        public decimal productid { get; set; }
        public decimal amount { get; set; }
        public string CLientname { get; set; }
        public string productname { get; set; }
    }

  
    }
    

