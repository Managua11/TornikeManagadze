namespace practice_01
{
    class PublicTransport : Vehicle
    {
        public PublicTransportType Type { get; set; }
        public int PassengerCapacity { get; set; }

        public PublicTransport(string name, int speed, int weight, PublicTransportType type, int passengerCapacity)
            : base(name, speed, weight)
        {
            Type = type;
            PassengerCapacity = passengerCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Public Transport Type: {Type}, Passenger Capacity: {PassengerCapacity}");
        }
    }
}
