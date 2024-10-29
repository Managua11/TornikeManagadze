namespace practice_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string str = Console.ReadLine();
            string binaryNum = "";
            if (int.TryParse(str, out int val))
            {
                while(val >= 1)
                {
                    int rem = val % 2;
                    val = val / 2;
                    binaryNum = rem + binaryNum;
                }
            }
            Console.WriteLine(binaryNum);
        }
    }
}
