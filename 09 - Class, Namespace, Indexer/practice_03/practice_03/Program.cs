namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            Console.Write("Enter hours: ");
            clock.Hours = int.Parse(Console.ReadLine());

            Console.Write("Enter minutes: ");
            clock.Minutes = int.Parse(Console.ReadLine());

            Console.Write("Enter seconds: ");
            clock.Seconds = int.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++) clock.AddSecond();
            Console.WriteLine("GetCurrentTime() is called AddSecond() 4 times. the output should be:");
            clock.GetCurrentTime();

            for (int i = 0; i < 3; i++) clock.AddSecond();
            Console.WriteLine("AddSecond() is called 3 times.");

            clock.AddMinute();
            Console.WriteLine("then if AddMinute() is called one time, the output of GetCurrentTime() should be:");
            clock.GetCurrentTime();

        }
    }
}