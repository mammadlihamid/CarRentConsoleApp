using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rent_App.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int DoorCount { get; set; }
        public string FuelType { get; set; }
        public string Type { get; set; }
        public int Count { get; set; } = 0;
    }
}
