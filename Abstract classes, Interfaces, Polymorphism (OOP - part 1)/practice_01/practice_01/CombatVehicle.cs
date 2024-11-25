namespace practice_01
{
    class CombatVehicle : Vehicle
    {
        public CombatVehicleType Type { get; set; }

        public CombatVehicle(string name, int speed, int weight, CombatVehicleType type)
            : base(name, speed, weight)
        {
            Type = type;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Combat Vehicle Type: {Type}");
        }

        public void FireWeapon()
        {
            Console.WriteLine($"{Name} is firing weapons!");
        }
    }
}
