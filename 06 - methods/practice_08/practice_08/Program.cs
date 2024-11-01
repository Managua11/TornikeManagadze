namespace practice_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = getInt();
            getSructure(num);
        }
        static string getInt() {
            while (true) {
                Console.Write("Enter positive integer ");
                string str = Console.ReadLine();
                if (int.TryParse(str, out int val) && val >= 0)
                {
                    return str;
                }
            }
        }

        static void getSructure(string num){
            int pow = 0;
            int length = num.Length;
            for (int i = 0; i < length; i++)
            {
                int digit = num[i] - '0'; 
                if (digit >= 0)
                {
                    
                    int power = length - 1 - i; 
                    Console.Write($"{digit} * 10^{power}");
                    if (i < length - 1)
                    {
                        Console.Write(" + ");
                    }
                }
            }
        }
    }
}
