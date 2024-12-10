namespace TemperatureMonitoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();

            monitor.TemperatureAlert += alert.OnTemperatureAlert;

            Console.WriteLine("Enter temperatures (type 'exit' to quit):");

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting program.");
                    break;
                }

                if (double.TryParse(input, out double temperature))
                {
                    monitor.CheckTemperature(temperature);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value or 'exit'.");
                }
            }
        }
    }
}
