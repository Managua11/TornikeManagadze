namespace practice_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];

            Console.WriteLine("Fill first matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Fill second matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("here is the sum of two matrices: ");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0;j < cols; j++)
                {
                    int sum = matrix1[(int)i, j] + matrix2[(int)i, j];
                    Console.Write(sum + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
