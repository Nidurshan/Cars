using Cars.API.Data;
using Cars.API.Interfaces;
using Cars.API.Models;
using System.Text;

namespace Cars.API.Services
{
    public class CarsRepository : ICarsRepository
    {
        private static List<Car> cars = Database.Cars;

        public List<Car> GetAll()
        {
            return cars;
        }

        public Car GetById(int id)
        {
            return cars.Single(c => c.Id == id);
        }

        public int Create(Car car)
        {
            cars.Add(car);
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
            cars.Remove(existingCar);
            return existingCar.Id;
        }

        public string RemoveWheels(int id, int wheelCountToRemove)
        {
            var existingCar = GetById(id);
            existingCar.Wheels = existingCar.Wheels - wheelCountToRemove;
            return $"Removed {wheelCountToRemove} wheels from {existingCar.Name}";
        }

        public string ChangeColor(int id, string newColor)
        {
            var existingCar = GetById(id);
            var carName = existingCar.Name;
            var currentColor = existingCar.Color;
            existingCar.Color = newColor;
            return $"{carName} is color washed from {currentColor} to {newColor}";
        }

        public string CarSale(int id)
        {
            var existingCar = GetById(id);
            var carName = existingCar.Name;
            existingCar.Sold = true;
            return $"{carName} car is sold!";
        }

        public string GetSoldCars()
        {
            var soldCars= cars.Where(c => c.Sold == true).ToArray();
            StringBuilder getSoldCars= new StringBuilder();

            for (int i = 0; i < soldCars.Length; i++)
            {
                getSoldCars.AppendLine($"Sold cars: {soldCars[i].Name}");              
            }

            return getSoldCars.ToString();
        }
    }
}