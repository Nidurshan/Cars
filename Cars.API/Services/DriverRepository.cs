using Cars.API.Interfaces;
using Cars.API.Models;

namespace Cars.API.Services
{
    public class DriverRepository : IDriverRepository
    {
        public static List<Driver> drivers = new List<Driver>()
        {
            new Driver(1, "John", 30),
            new Driver(2, "Sam", 35),
            new Driver(3, "Harry", 40),
            new Driver(4, "Tom", 28)
        };

        public List<Driver> GetDrivers()
        {
            return drivers;
        }

        public Driver GetDriverById(int id)
        {
            return drivers.Single(d => d.Id == id);
        }

        public int CreateDriver(Driver driver)
        {
            drivers.Add(driver);
            return driver.Id;
        }

        public int UpdateDriver(Driver driver)
        {
            var existingDriver = drivers.Single(d => d.Id == driver.Id);

            existingDriver.Name = driver.Name;
            existingDriver.Age = driver.Age;
            return existingDriver.Id;
        }

        public int DeleteDriver(int id)
        {
            var existingDriver = drivers.Single(d => d.Id == id);
            drivers.Remove(existingDriver);
            return id;
        }
    }
}
