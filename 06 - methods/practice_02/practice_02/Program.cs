namespace practice_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 989 };
            Console.Write("Enter index: ");
            string str = Console.ReadLine();
            if (int.TryParse(str, out int ind))
            {
                Console.WriteLine(digitSum(ints, ind));
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
        static int digitSum(int[] ints, int ind) {
            if (0 < ind && ind < ints.Length - 1)
            {
                int num = ints[ind];
                int sum = 0;
                while (num > 10)
                {
                    int rem = num % 10;
                    sum += rem;
                    num = (num - rem) / 10;
                }
                sum += num;
                return sum;
            }
            else
            {
                Console.WriteLine("out of range!");
                return -1;
            }
        }

    }
}
