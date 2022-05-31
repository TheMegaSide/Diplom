using System;

namespace FInalProject.Models
{
    public class Driver
    {
        public int id { get; set; }
        
        public string name { get; set; }
        
        public int drcertnum{ get; set; }
        public DateTime drcertdate{ get; set; }
        public string classs{ get; set; }
        public string timedriving{ get; set; }
        public int auto { get; set; }
    }
}