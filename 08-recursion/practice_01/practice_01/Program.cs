namespace practice_01
{
    internal class Program
    {
        
            static void PrintNumbers(int n)
            {
                if (n < 0)
                {
                    return;
                }
                PrintNumbers(n - 1);
                Console.Write(n + " ");
            }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            PrintNumbers(number);
        }
    }
}
