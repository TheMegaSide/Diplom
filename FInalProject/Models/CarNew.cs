using System;

namespace FInalProject.Models
{
    public class CarNew
    {
        public int id { get; set; }
        public string type { get; set; }
        public string model{ get; set; }
        public string vin { get; set; }
        public int yearprod { get; set; }
        public string govnum{ get; set; }
        public double value{ get; set; }
        public int weight{ get; set; }
        public int maxweight{ get; set; }
        public string fueltype{ get; set; }
        public string techstate{ get; set; }
        public DateTime srokpodk{ get; set; }
        public string inscomp{ get; set; }
        public double osagocost{ get; set; }
        public string platonnum{ get; set; }
        public DateTime platondate{ get; set; }
        public string platonreplace{ get; set; }
        public string glonastype{ get; set; }
        public string simnum{ get; set; }
        public DateTime glonasdate{ get; set; }
        public string worktype{ get; set; }
        public string ptsowner{ get; set; }
        public string stsowner{ get; set; }
        public string regionloc{ get; set; }
    }
}