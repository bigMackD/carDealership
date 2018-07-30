using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership.Models
{
    public abstract class Transaction
    {
        public DateTime Date { get; set; }
        public Car Car { get; set; }
        public bool IsIncoming { get; set; }
        public int Price { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Model of car: {Car.Model}");
            Console.WriteLine($"Transaction incoming:{IsIncoming}");
            Console.WriteLine($"Value of transaction:{Price}");
        }
    }
}
