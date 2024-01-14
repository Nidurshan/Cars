using Cars.API.Data;
using Cars.API.Interfaces;
using Cars.API.Models;
using System.Collections.Specialized;

namespace Cars.API.Services
{
    public class DriverRepository : IDriverRepository
    {
        public static List<Driver> drivers = Database.Drivers;

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

        public string ManageRetiredDrivers()
        {
            var count = 0;

            for (int i = 0; i < drivers.Count; i++)
            {
                if (drivers[i].Age > 50)
                {
                    drivers[i].Retired = true;
                    count++;
                }
            }

            var dateTimeNow = DateTimeOffset.UtcNow.ToString("dd/MM/yyyy HH:mm:ss");

            return $"Marked {count} drivers as retired on {dateTimeNow}";
        }
    }
}
