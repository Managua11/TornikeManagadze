namespace practice_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string str = Console.ReadLine();
            if (int.TryParse(str, out int num))
            {
                for (int i = 1; i <= num; i++)
                {
                    int pow = (int)Math.Pow(i, 3);
                    Console.WriteLine(i + " cubed is : " + pow);

                }
            }
            else
            {
                Console.WriteLine("invalid input!");
            }    
        }
    }
}
