namespace Cars.API.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Driver(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
