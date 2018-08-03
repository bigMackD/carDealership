using carDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership.Repositories
{
    class AllCarsRepository
    {
        private static List<Car> _carRepository = new List<Car>();

        public void AddCar(Car car)
        {
            _carRepository.Add(car);
        }

        public void RemoveCar(int index)
        {
            _carRepository.RemoveAt(index);
        }
        
        public Car GetCar(int index)
        {
            return _carRepository[index];
        }
        public IEnumerable<Car> GetAllCars()
        {
            return _carRepository;
        }
    }
}
