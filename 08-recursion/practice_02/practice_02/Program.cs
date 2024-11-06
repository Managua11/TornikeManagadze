namespace practice_02
{
    internal class Program
    {
        static int CalculateSum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n + CalculateSum(n - 1);
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = CalculateSum(number);
            Console.WriteLine($"The sum of numbers from 0 to {number} is: {sum}");
        }
    }
}
