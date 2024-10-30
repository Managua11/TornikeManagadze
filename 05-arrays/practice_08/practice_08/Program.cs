namespace practice_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 0, 1, 1, 1, 1, 1, 1, 1 },
                              { 0, 0, 1, 1, 1, 1, 1, 1 },
                              { 0, 0, 0, 1, 1, 1, 1, 1 },
                              { 0, 0, 0, 0, 1, 1, 1, 1 },
                              { 0, 0, 0, 0, 0, 1 ,1, 1 },
                              { 0, 0, 0, 0, 0, 0, 1, 1 },
                              { 0, 0, 0, 0, 0, 0, 0, 1 },
                              { 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            int[,] rotated = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int curr = matrix[i, j];
                    rotated[7 - i, j] = curr;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(rotated[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}