

namespace practice_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = fillArray();
            char ch = ' ';
            while (true)
            {
                Console.WriteLine("Enter character: ");
                string str = Console.ReadLine();
                if(str.Length == 1)
                {
                    ch = str[0];
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input enter character! ");
                    str = Console.ReadLine();
                }
            }
            int countChar = getNum(chars, ch);
            printAns(countChar);
        }

        static void printAns(int countChar)
        {
            Console.WriteLine(countChar);
        }

        static int getNum(char[] chars, char ch)
        {
            int count = 0;
            for (int i = 0; i < chars.Length; i++) {
                if (chars[i] == ch) count++;
            }
            return count;
        }

        static char[] fillArray()
        {
            int size = 0;
            Console.Write("Enter size of array ");
            string str = Console.ReadLine();

            while (!int.TryParse(str, out size))
            {

                Console.Write("Invalid input, enter integer value! ");
                str = Console.ReadLine();
            }
            char[] arr = new char[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter value for index " + i);
                while (true)
                {
                    string input = Console.ReadLine() ; 
                    if(input.Length == 1)
                    {
                        arr[i] = input[0];
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input enter character! ");
                    }
                }
            }
            return arr;

        }

    }
}
