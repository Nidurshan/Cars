using Cars.API.Interfaces;
using Cars.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IDriverRepository _driverRepository;

        public DriversController(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        [HttpGet]
        public List<Driver> GetAllDrivers()
        {
            return _driverRepository.GetDrivers();
        }

        [HttpGet("{id}")]
        public Driver GetDriverById(int id)
        {
            return _driverRepository.GetDriverById(id);
        }

        [HttpPost]
        public int CreateDriver(Driver driver)
        {
            return _driverRepository.CreateDriver(driver);
        }

        [HttpPut]
        public int UpdateDriver(Driver driver)
        {
            return _driverRepository.UpdateDriver(driver);
        }

        [HttpDelete("{id}")]
        public int DeleteDriver(int id)
        {
            return _driverRepository.DeleteDriver(id);
        }

        [HttpPut("retired/manage")]
        public string ManageRetiredDrivers()
        {
            return _driverRepository.ManageRetiredDrivers();
        }
        
    }
}
