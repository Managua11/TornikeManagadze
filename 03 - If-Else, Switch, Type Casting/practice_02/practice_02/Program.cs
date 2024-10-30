namespace practice_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            Console.Write("Enter third number: ");
            string input3 = Console.ReadLine();

            if (int.TryParse(input1, out int a) &&
                int.TryParse(input2, out int b) &&
                int.TryParse(input3, out int c))
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    Console.WriteLine("This should be a triangle !");
                }
                else
                {
                    Console.WriteLine("The numbers cannot form a triangle.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
        }
    }
}
