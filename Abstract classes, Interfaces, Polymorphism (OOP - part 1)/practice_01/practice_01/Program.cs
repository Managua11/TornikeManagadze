using practice_01;
using System;

namespace practice_01
{
    enum VehicleType
    {
        Combat,
        Regular,
        Sports,
        Public
    }

    enum CombatVehicleType { Tank, BTR, APC }

    enum RegularVehicleType { Sedan, Bicycle, Hatchback, Motorbike }

    enum SportsCarType { F1, OffRoad, Rally }

    enum PublicTransportType { Bus, Tram, Metro }



    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a type of vehicle:");
                foreach (var type in Enum.GetValues(typeof(VehicleType)))
                {
                    Console.WriteLine($"- {type}");
                }

                if (Enum.TryParse(Console.ReadLine(), true, out VehicleType selectedType))
                {
                    switch (selectedType)
                    {
                        case VehicleType.Combat:
                            VehicleHelper.ShowCombatOptions();
                            break;
                        case VehicleType.Regular:
                            VehicleHelper.ShowRegularOptions();
                            break;
                        case VehicleType.Sports:
                            VehicleHelper.ShowSportsOptions();
                            break;
                        case VehicleType.Public:
                            VehicleHelper.ShowPublicTransportOptions();
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }

                Console.WriteLine("\nDo you want to choose another vehicle? (yes/no)");
                if (Console.ReadLine()?.ToLower() != "yes") break;
            }
        }
    }
}
