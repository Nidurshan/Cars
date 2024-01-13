using Cars.API.Models;

namespace Cars.API.Interfaces
{
    public interface ICarsRepository
    {
        List<Car> GetAll();

        Car GetById(int id);

        int Create(Car car);

        int Update(Car car);

        int Delete(int id);

        string RemoveWheels(int id, int wheelCountToRemove);

        string ChangeColor(int id, string newColor);

        string CarSale(int id);

        string GetSoldCars();
    }
}
