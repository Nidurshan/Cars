namespace Cars.API.Models
{
    public class Car
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = null!;
        public int Wheels { get; set; } = 0;
        public string Color {  get; set; }
        public bool Sold { get; set; } = false;

        public Car(int id, string name, int wheels, string color, bool sold)
        {
            Id = id;
            Name = name;
            Wheels = wheels;
            Color = color;
            Sold = sold;
        }
    }
}