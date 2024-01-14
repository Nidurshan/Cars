using Cars.API.Models;

namespace Cars.API.Data
{
    public static class Database
    {

        public static List<Car> Cars { get; set; } = new List<Car>
        {
            new Car(1, "Tesla", 4, "Red", false),
            new Car(2, "Audi", 8, "Black", false),
            new Car(3, "BMW", 4, "Gray", false),
            new Car(4, "Lambogini", 6, "Orange", false),
            new Car(5, "Ferrari", 4, "Red", false)
        };

        public static List<Driver> Drivers { get; set; } = new List<Driver>()
        {
            new Driver(1, "John", 30, false),
            new Driver(2, "Sam", 51, false),
            new Driver(3, "Harry", 50, false),
            new Driver(4, "Tom", 16, false)
        };
    }
}
