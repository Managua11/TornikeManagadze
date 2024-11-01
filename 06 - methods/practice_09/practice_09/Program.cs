namespace practice_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static int muliply(params int[] x) {
            if (x.Length == 0) {
                return 0;
            }
            int total = 1;
            for (int i = 0; i < x.Length; i++) { 
                total *= x[i];  
            }
            return total;
        }
    }
}
