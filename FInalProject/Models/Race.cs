using System;

namespace FInalProject.Models
{
    public class Race
    {
        public int id { get; set; }
        public double value { get; set; }
        public double raceTime { get; set; }
        public int driver{ get; set; }
        public string driverName { get; set; }
        public int auto{ get; set; }
        public string autoGovnum { get; set; }
        public DateTime date{ get; set; }
    }
}