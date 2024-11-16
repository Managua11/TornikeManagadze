namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int size = int.Parse(num);
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) { 
                string mmbr = Console.ReadLine();
                int nMMbr = int.Parse(mmbr);    
                arr[i] = nMMbr;
            }
            string target = Console.ReadLine();
            int a = int.Parse(target);
            findSum(a, arr);
        }

        static void findSum(int number, int[] array)
        {
            int start = 0;
            int end = array.Length - 1;
            if (array.Length < 2) {
                return;
            }
            while(start < end) 
            {
                int sum = array[start] + array[end];
                if (sum == number)
                {
                    Console.WriteLine(array[start] + " " + array[end]);
                    start++;
                    end--;
                }
                else if(sum < number)
                {
                    start = start + 1;
                }else if(sum > number)
                {
                    end = end - 1;
                }
            }
        }
    }
}
