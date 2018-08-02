using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership.Models
{
   
   public class Bill : Transaction
    {
        public int Nip { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Nip:{Nip}");
        }
    }
    
}
