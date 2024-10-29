namespace practice_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string str  = Console.ReadLine();
            Console.WriteLine(str);
            if (int.TryParse(str, out int val))
            {
                Console.Write("Divisors of" + val + "are: ");
                for (int i = 1; i <= val / 2; i++)
                {
                    if (val % i == 0)
                    {
                        Console.Write(i);
                        Console.Write(", ");
                    }
                }
                Console.Write(val);
            }
            else {
                Console.WriteLine("invalid input!");
            }
        }
    }
}
