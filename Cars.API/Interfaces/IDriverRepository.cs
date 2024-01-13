using Cars.API.Models;

namespace Cars.API.Interfaces
{
    public interface IDriverRepository
    {
        List<Driver> GetDrivers();

        Driver GetDriverById(int id);

        int CreateDriver(Driver driver);

        int UpdateDriver(Driver driver);

        int DeleteDriver(int id);

        string FindRetiredDrivers();

        //string GetRetiredDrivers();
    }
}
