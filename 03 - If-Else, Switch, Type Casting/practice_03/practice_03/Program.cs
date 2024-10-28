namespace practice_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");

            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                double squaredValue = number * number;
                Console.WriteLine($"The pow  of the entered number is: {squaredValue}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
