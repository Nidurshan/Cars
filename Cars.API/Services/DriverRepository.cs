using Cars.API.Interfaces;
using Cars.API.Models;
using System.Text;

namespace Cars.API.Services
{
    public class DriverRepository : IDriverRepository
    {
        public static List<Driver> drivers = new List<Driver>()
        {
            new Driver(1, "John", 30, false),
            new Driver(2, "Sam", 51, false),
            new Driver(3, "Harry", 40, false),
            new Driver(4, "Tom", 60, false)
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

        public string FindRetiredDrivers()
        {
            List<string> retiredDrivers = new List<string>();

            for (int i = 0; i < drivers.Count; i++)
            {
                if (drivers[i].Age >= 50)
                {
                    drivers[i].Retired = true;
                    retiredDrivers.Add(drivers[i].Name);
                }
            }

            string retiredDriversString = string.Join(", ", retiredDrivers);
            return retiredDriversString;
        }

        //public string GetRetiredDrivers()
        //{
            
        //}
    }
}
