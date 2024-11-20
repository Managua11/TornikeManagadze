namespace practice_01
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Weight { get; set; }

        public Vehicle(string name, int speed, int weight)
        {
            Name = name;
            Speed = speed;
            Weight = weight;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Speed: {Speed} km/h, Weight: {Weight} kg");
        }
    }
}

