using Cars.API.Interfaces;
using Cars.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarsRepository _carsRepository;

        public CarsController(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }

        [HttpGet]
        public List<Car> GetAll()
        {
            return _carsRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Car GetById(int id)
        {
            return _carsRepository.GetById(id);
        }

        [HttpPost]
        public int Create(Car car)
        {
            return _carsRepository.Create(car);
        }

        [HttpPut]
        public int Update(Car car)
        {
            return _carsRepository.Update(car);
        }

        [HttpPut("{id}/remove-wheels")]
        public string RemoveWheels(int id, int wheelCountToRemove)
        {
            return _carsRepository.RemoveWheels(id, wheelCountToRemove);
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _carsRepository.Delete(id);
        }

        [HttpPut("{id}/new-color{newColor}")]
        public string ChangeColor(int id, string currentColor, string newColor)
        {
            return _carsRepository.ChangeColor(id, currentColor, newColor);
        }

        [HttpPut("{id}/car-sale")]
        public string CarSale(int id, bool sold)
        {
            return _carsRepository.CarSale(id, sold);
        }
    }
}
