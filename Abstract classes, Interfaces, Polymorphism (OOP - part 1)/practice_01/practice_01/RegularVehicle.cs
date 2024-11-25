namespace practice_01
{
    class RegularVehicle : Vehicle
    {
        public RegularVehicleType Type { get; set; }

        public RegularVehicle(string name, int speed, int weight, RegularVehicleType type)
            : base(name, speed, weight)
        {
            Type = type;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Regular Vehicle Type: {Type}");
        }
    }
}

