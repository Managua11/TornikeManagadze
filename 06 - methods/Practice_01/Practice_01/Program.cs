namespace Practice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = {  1, 2, 3 };
            Console.Write("Enter index: ");
            string str = Console.ReadLine();
            if(int.TryParse(str, out int ind)){
                int res = getNum(ints, ind);
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

        static int getNum(int[] ints, int index) {
            if (0 <= index && index < ints.Length - 1) 
            {
                return ints[index];
            }
            else
            {
                Console.WriteLine("index out of range!");
                return -1;
            }
            
        }
    }
}
