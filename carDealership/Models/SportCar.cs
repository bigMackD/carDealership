using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership.Models
{
    public class SportCar : Car
    {
        public int HorsePower { get; set; }
        
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Horsepower: {HorsePower}");
        }

    }
}
