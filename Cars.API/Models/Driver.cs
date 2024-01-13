namespace Cars.API.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Retired { get; set; } = false;

        public Driver(int id, string name, int age, bool retired)
        {
            Id = id;
            Name = name;
            Age = age;
            Retired = retired;
        }
    }
}
