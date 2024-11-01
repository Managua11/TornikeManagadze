using System.Globalization;

namespace practice_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = fillArray();
            int[] minMax = getMinMax(arr);
            Console.WriteLine(minMax[0] + " " + minMax[1]);

        }

        static int[] getMinMax(int[] arr)
        {
            int[] minMax = new int[2];
            int min = 0, max = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max) { 
                    max = arr[i];
                }
            }
            minMax[0] = min;
            minMax[1] = max;
            return minMax;
        }

        static int[] fillArray()
        {
            int size = 0;
            Console.Write("Enter size of array ");
            string str = Console.ReadLine();

            while (!int.TryParse(str, out size)) {

                Console.Write("Invalid input, enter integer value! ");
                str = Console.ReadLine();
            }
            int[] ints = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter value for index " + i);
                string num = Console.ReadLine();
                int val;
                while(!int.TryParse(num, out val))
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
