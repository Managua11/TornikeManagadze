
using System.Security.Cryptography.X509Certificates;

namespace practice_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = fillArray();
            Console.Write("Enter value ");
            string str = Console.ReadLine();
            int val;
            while(!int.TryParse(str, out val))
            {
                Console.WriteLine("Invalid input enter integer! ");
                str = Console.ReadLine();
            }
            int factorial = findNum(arr, val);
            if (factorial > 0) {
                Console.WriteLine("Factorial of " + val + "is " + factorial);

            }
            else
            {
                Console.WriteLine("Number" + val + " was not found in the given array");
            }
        }

        static int findNum(int[] arr, int val)
        {
            int ans = 0;
            for (int i = 0; i < arr.Length; i++) { 
                if(arr[i] == val)
                {
                    ans = getFactorial(arr[i]);
                }
            }
            return ans;
        }

        static int getFactorial(int v)
        {
            if(v == 1)
            {
                return 1;
            }
            return v * getFactorial(v - 1);
        }

        static int[] fillArray()
        {
            int size = 0;
            Console.Write("Enter size of array ");
            string str = Console.ReadLine();

            while (!int.TryParse(str, out size))
            {

                Console.Write("Invalid input, enter integer value! ");
                str = Console.ReadLine();
            }
            int[] ints = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter value for index " + i);
                string num = Console.ReadLine();
                int val;
                while (!int.TryParse(num, out val))
                {
                    Console.Write("Invalid input enter integer! ");
                    num = Console.ReadLine();
                }
                ints[i] = val;
            }
            return ints;

        }

    }

}
