using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carDealership.Factories;
using carDealership.Repositories;

namespace carDealership
{
    class Program
    {
        private static AllCarsRepository _allCarsRepository = new AllCarsRepository();
        private static readonly CarFactory _carFactory = new CarFactory();
        private static readonly TransactionFactory _transactionFactory = new TransactionFactory();
        private static AllTransactionsRepository _allTransactionsRepository = new AllTransactionsRepository();
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    DisplayMainMenu();
                    var chosenOption = Console.ReadKey(true);
                    switch (chosenOption.Key)
                    {
                        case ConsoleKey.D1:
                            AddCar();
                            break;
                        case ConsoleKey.D2:
                            SellCar();
                            break;
                        case ConsoleKey.D3:
                            DisplayAllCars();
                            break;
                        case ConsoleKey.D4:
                            DisplayAllTransactions();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error has occured!");
                    Console.WriteLine($"Exeption message: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Press escape to exit or any other key to go again!");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
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
            var index = 1;
            foreach (var car in carsList)
            {
                Console.WriteLine("");
                Console.WriteLine($"{index}.");
                car.Display();
                index++;

            }
        }

        public static void DisplayAllTransactions()
        {
            var transactionsList = _allTransactionsRepository.GetAllTransactions();
            var index = 1;
            foreach(var transaction in transactionsList)
            {
                Console.WriteLine("");
                Console.WriteLine($"{index}.");
                transaction.Display();
                index++;
            }
        }

        public static void AddCar()
        {
            var car = _carFactory.CreateCar();
            _allCarsRepository.AddCar(car);
            var transaction = _transactionFactory.CreateTransaction(car, true);
            _allTransactionsRepository.AddTransaction(transaction);

        }

        public static void SellCar()
        {
            Console.WriteLine("Which car do you want to sell?(select from car list)");
            var index = int.Parse(Console.ReadLine());
            var transaction = _transactionFactory.CreateTransaction(_allCarsRepository.GetCar(index), false);
            _allTransactionsRepository.AddTransaction(transaction);
            _allCarsRepository.RemoveCar(index);
        }
    }
}
