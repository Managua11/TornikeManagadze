namespace practice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 7;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            swapValues(ref num1,ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        static void swapValues(ref int num1, ref int num2)
        {
            num1 = num1 ^ num2;
            num2 = num2 ^ num1;
            num1 = num1 ^ num2;
        }
    }
}