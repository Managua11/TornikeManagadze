namespace practice_01
{
    class SportsCar : Vehicle
    {
        public SportsCarType Type { get; set; }
        public int HorsePower { get; set; }

        public SportsCar(string name, int speed, int weight, SportsCarType type, int horsePower)
            : base(name, speed, weight)
        {
            Type = type;
            HorsePower = horsePower;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Sports Car Type: {Type}, HorsePower: {HorsePower} HP");
        }
    }
}
