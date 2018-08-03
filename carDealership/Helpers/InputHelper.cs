using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership.Helpers
{
    public class InputHelper
    {
        
        public int getIntFromConsole(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if(int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Wrong input format. Try again!");
                return getIntFromConsole(message);
            }
        }
    }
}
