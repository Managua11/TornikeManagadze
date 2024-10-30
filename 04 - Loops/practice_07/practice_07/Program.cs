namespace practice_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            Console.Write("Enter number: ");
            string str = Console.ReadLine();
            if (int.TryParse(str, out int num))
            {
                for (int i = 0; i <= num; i++) {
                    Console.Write(a + ", ");
                    int next = a + b;
                    a = b;
                    b = next;
                }
            }

        }
    }
}
