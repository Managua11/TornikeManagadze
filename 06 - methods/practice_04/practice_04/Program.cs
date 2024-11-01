namespace practice_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = fillArray();
            Console.WriteLine(getAverage(array));
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

        static double getAverage(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (double)sum / array.Length;
        }
    }
}
