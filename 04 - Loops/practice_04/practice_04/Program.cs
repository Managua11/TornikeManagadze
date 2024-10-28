namespace practice_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            String str = Console.ReadLine();
            if (int.TryParse(str, out int val))
            {
                int sum = 0;
                for (int i = 1; i <= val; i++)
                {
                    if (i % 2 == 0)
                    {
                        continue;
                    }
                    sum += i;
                }
                Console.WriteLine("Sum of odd numbers from 1 to " + str + " is " + sum);
            }
            else
            {
                Console.WriteLine("invalid input!");
            }
        }
    }
}
