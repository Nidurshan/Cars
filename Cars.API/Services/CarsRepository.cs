using Cars.API.Interfaces;
using Cars.API.Models;
using System.ComponentModel.DataAnnotations;

namespace Cars.API.Services
{
    public class CarsRepository : ICarsRepository
    {
        private static List<Car> Cars = new List<Car>
        {
            new Car(1, "Tesla", 1, "Red", false),
            new Car(2, "Audi", 6, "Black", false),
            new Car(3, "BMW", 4, "Gray", false)
        };

        public List<Car> GetAll()
        {
            return Cars;
        }

        public Car GetById(int id)
        {
            return Cars.Single(c => c.Id == id);
        }

        public int Create(Car car)
        {
            Cars.Add(car);
            return car.Id;
        }

        public int Update(Car car)
        {
            //var existingCar = Cars.Single(c => c.Id == car.Id);
            var existingCar = GetById(car.Id);
            existingCar.Name = car.Name;
            existingCar.Wheels = car.Wheels;
            return existingCar.Id;
        }

        public int Delete(int id)
        {
            //var existingCar = Cars.Single(c => c.Id == id);
            var existingCar = GetById(id);
            Cars.Remove(existingCar);
            return existingCar.Id;
        }

        public string RemoveWheels(int id, int wheelCountToRemove)
        {
            var existingCar = GetById(id);
            existingCar.Wheels = existingCar.Wheels - wheelCountToRemove;
            return $"Removed {wheelCountToRemove} wheels from {existingCar.Name}";
        }

        public string ChangeColor(int id, string currentColor, string newColor)
        {
            var existingCar = GetById(id);
            var carName = existingCar.Name;
            currentColor = existingCar.Color;
            var paintedCar = existingCar.Color = newColor;
            return $"{carName} is color washed from {currentColor} to {paintedCar}";
        }

        public string CarSale(int id, bool sold)
        {
            var existingCar = GetById(id);
            var car = existingCar.Name;
            sold = existingCar.Sold;
            
            if (sold)
            {
                return $"{car} car was Sold!";
                sold = true;
            }
            else
            {
                return $"{car} car was not Sold!";
                sold = false;
            }
        }
    }
}
