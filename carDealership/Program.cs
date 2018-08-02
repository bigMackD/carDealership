using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carDealership.Repositories;

namespace carDealership
{
    class Program
    {
        private static AllCarsRepository _allCarsRepository = new AllCarsRepository();
        private static AllTransactionsRepository _allTransactionsRepository = new AllTransactionsRepository();
        static void Main(string[] args)
        {
        }

        public static void DisplayMainMenu()
        {
            Console.WriteLine("Car dealership");
            Console.WriteLine("What you want to do?");
            Console.WriteLine("1. Add/Buy car");
            Console.WriteLine("2. Remove/Sell car");
            Console.WriteLine("3. View all cars");
            Console.WriteLine("4. View all transactions made");
        }

        public static void DisplayAllCars()
        {
            var carsList = _allCarsRepository.GetAllCars();
            foreach (var car in carsList)
            {
                car.Display();
            }
        }

        public static void DisplayAllTransactions()
        {
            var transactionsList = _allTransactionsRepository.GetAllTransactions();
            foreach(var transaction in transactionsList)
            {
                transaction.Display();
            }
        }
    }
}
