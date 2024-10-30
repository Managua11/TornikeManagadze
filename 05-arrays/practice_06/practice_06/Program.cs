namespace practice_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array row size: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter array column size: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Here is matrix view of multidimensional array");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + ", "); 
                }
                Console.WriteLine();
            }
        }
    }
}
