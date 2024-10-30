namespace practice_02
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
                Console.WriteLine("here is your array!");
                for (int i = val - 1; i >= 0; i--)
                {
                    Console.WriteLine(nums[i]);
                }

            }
            else
            {
                Console.WriteLine("invalid input!");
            }

        }
    }
}