namespace practice_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2021;
            bool isLeapYear = ((year & 3) == 0);
            Console.WriteLine(isLeapYear);
        }
    }
}
