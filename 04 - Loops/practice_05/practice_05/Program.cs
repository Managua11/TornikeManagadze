using System;

namespace practice_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows of Floyd's triangle to be printed: ");
            string str = Console.ReadLine();

            if (int.TryParse(str, out int value))
            {
                for (int i = 1; i <= value; i++)
                {

                    int start = (i % 2 == 0) ? 0 : 1;

                    for (int j = 0; j < i; j++)
                    { 
                        Console.Write((start + j) % 2 + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
