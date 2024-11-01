


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

            int[,] matrix1 = getArray(rows, cols);
            int[,] matrix2 = getArray(rows, cols);
            int[,] sum = addArrays(matrix1, matrix2);
            printSum(sum);
            
        }

        static void printSum(int[,] sum)
        {
            Console.WriteLine("Here is the sum of matrices");
            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for(int j = 0; j < sum.GetLength(1); j++)
                {
                    Console.Write(sum[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }

        static int[,] addArrays(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] ans = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    ans[i, j] = matrix1[i,j] + matrix2[i, j];
                }

            }
            return ans;
        }

        static int[,] getArray(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Fill matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }
    }
}
