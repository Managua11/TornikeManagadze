namespace practice_01

{
    static class VehicleHelper
    {
        public static void ShowCombatOptions()
        {
            foreach (var type in Enum.GetValues(typeof(CombatVehicleType)))
            {
                Console.WriteLine($"- {type}");
            }

            Console.WriteLine("Enter your choice:");
            if (Enum.TryParse(Console.ReadLine(), true, out CombatVehicleType selectedType))
            {
                var combatVehicle = new CombatVehicle(selectedType.ToString(), 60, 50000, selectedType);
                combatVehicle.DisplayInfo();
                combatVehicle.FireWeapon();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        public static void ShowRegularOptions()
        {
            foreach (var type in Enum.GetValues(typeof(RegularVehicleType)))
            {
                Console.WriteLine($"- {type}");
            }

            Console.WriteLine("Enter your choice:");
            if (Enum.TryParse(Console.ReadLine(), true, out RegularVehicleType selectedType))
            {
                var regularVehicle = new RegularVehicle(selectedType.ToString(), 120, 1500, selectedType);
                regularVehicle.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        public static void ShowSportsOptions()
        {
            foreach (var type in Enum.GetValues(typeof(SportsCarType)))
            {
                Console.WriteLine($"- {type}");
            }

            Console.WriteLine("Enter your choice:");
            if (Enum.TryParse(Console.ReadLine(), true, out SportsCarType selectedType))
            {
                var sportsCar = new SportsCar(selectedType.ToString(), 300, 1300, selectedType, 700);
                sportsCar.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        public static void ShowPublicTransportOptions()
        {
            foreach (var type in Enum.GetValues(typeof(PublicTransportType)))
            {
                Console.WriteLine($"- {type}");
            }

            Console.WriteLine("Enter your choice:");
            if (Enum.TryParse(Console.ReadLine(), true, out PublicTransportType selectedType))
            {
                var publicTransport = new PublicTransport(selectedType.ToString(), 80, 12000, selectedType, 50);
                publicTransport.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
