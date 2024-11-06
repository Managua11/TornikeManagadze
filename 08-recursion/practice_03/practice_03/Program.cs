namespace practice_03
{
    internal class Program
    {
        static int CountDigits(int number)
        {
            number = Math.Abs(number);

            if (number < 10)
            {
                return 1;
            }

            return 1 + CountDigits(number / 10);
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int digitCount = CountDigits(number);
            Console.WriteLine($"The number has {digitCount} digits.");
        }
    }
}
