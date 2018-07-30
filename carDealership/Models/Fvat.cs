using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership.Models
{
    class Fvat : Transaction
    {
        public int Percentage { get; set; }
        public string CompanyName { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Percentage of FVAT: {Percentage}");
            Console.WriteLine($"Name of company: {CompanyName}");
        }

    }
}
