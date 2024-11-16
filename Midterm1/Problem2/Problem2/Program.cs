namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int size = int.Parse(str);
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) { 
                string newNum = Console.ReadLine();
                int a = int.Parse(newNum);
                arr[i] = a;
            }
            Console.WriteLine(disapearedNum(arr) + " is missing");
        }

        static int disapearedNum(int[] arr)
        {
            int shouldBe = 0;
            int sum = 0;
            for (int i = 1; i <= arr.Length; i++)
            {
                shouldBe += i;
                sum += arr[i - 1];
            }
            Console.WriteLine(shouldBe + "should");
            Console.WriteLine(sum + "sum");
            int missedNum = (arr.Length + 1) - (sum - shouldBe);
            return missedNum;
        }
    }
}
