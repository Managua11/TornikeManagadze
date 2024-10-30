﻿namespace practice_03
{
    internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        string str = Console.ReadLine();
        if (int.TryParse(str, out int val) && val >= 0)
        {
            int[] nums = new int[val];
            for (int i = 0; i < val; i++)
            {
                Console.Write("Enter number for index " + i + ": ");
                string elem = Console.ReadLine();
                if (int.TryParse(elem, out int newElem))
                {
                    nums[i] = newElem;
                }
                else
                {
                    Console.WriteLine("invalid input!");
                }
            }
            int sum = 0;
            for (int i = 0; i < val; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine("Sum of array elements is: " + sum);

        }
        else
        {
            Console.WriteLine("invalid input!");
        }

    }
}
}