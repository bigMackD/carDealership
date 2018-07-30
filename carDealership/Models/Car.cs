using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership.Models
{
    public class Car
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public int NumberOfDoors { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"NumberOfDoors: {NumberOfDoors}");
        }
    }
}
