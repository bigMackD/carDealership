using carDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership.Factories
{
    public class CarFactory
    {
        public Car CreateCar()
        {
            Car createdCar = null;
            Console.WriteLine("Choose car type: ");
            Console.WriteLine("1. Sport car");
            Console.WriteLine("2. Truck");
            var chosenCar = Console.ReadKey(true);
            switch (chosenCar.Key)
            {
                case ConsoleKey.D1:
                    createdCar = CreateSportCar();
                    break;
                case ConsoleKey.D2:
                    createdCar = CreateTruck();
                    break;
            }
            return createdCar;
        }

        private Car CreateSportCar()
        {
            var sportCar = new SportCar();
            FillCarFields(sportCar);
            Console.WriteLine("Horsepower: ");
            sportCar.HorsePower = int.Parse(Console.ReadLine());
            return sportCar;

        }

        private Car CreateTruck()
        {
            var truck = new Truck();
            FillCarFields(truck);
            Console.WriteLine("Number of wheels: ");
            truck.NumberOfWheels = int.Parse(Console.ReadLine());
            return truck;
        }

        private void FillCarFields(Car car)
        {

            Console.WriteLine("Model: ");
            car.Model = Console.ReadLine();
            Console.WriteLine("Type: ");
            car.Type = Console.ReadLine();
            Console.WriteLine("Number of doors: ");
            car.NumberOfDoors = int.Parse(Console.ReadLine());

        }
    }
}
