namespace practice_04
{
    internal class Program
    {
        static int Power(int baseNum, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }

            return baseNum * Power(baseNum, exponent - 1);
        }

        static void Main()
        {
            Console.Write("Enter the base number: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            int result = Power(baseNum, exponent);
            Console.WriteLine($"{baseNum} raised to the power of {exponent} is: {result}");
        }
    }
}
