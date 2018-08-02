using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership.Models
{
    public class Truck : Car
    {
        public int NumberOfWheels { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Number of wheels: {NumberOfWheels}");
        }

    }
}
