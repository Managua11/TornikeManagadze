namespace practice_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string str = Console.ReadLine();
            if (int.TryParse(str, out int number))
            {
                int sum = 0;
                for (int i = 0; i <= number; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Sum from 1 to " + str + " is: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
