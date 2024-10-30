namespace practice_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[8][];
            matrix[0] = new int[] { 0, 1, 1, 1, 1, 1, 1, 1 };
            matrix[1] = new int[] { 0, 0, 1, 1, 1, 1, 1, 1 };
            matrix[2] = new int[] { 0, 0, 0, 1, 1, 1, 1, 1 };
            matrix[3] = new int[] { 0, 0, 0, 0, 1, 1, 1, 1 };
            matrix[4] = new int[] { 0, 0, 0, 0, 0, 1, 1, 1 };
            matrix[5] = new int[] { 0, 0, 0, 0, 0, 0, 1, 1 };
            matrix[6] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1 };
            matrix[7] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };

            int[][] rotated = new int[8][];
            for (int i = 0; i < 8; i++)
            {
                rotated[i] = new int[8]; 
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    rotated[7 - i][j] = matrix[i][j];
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(rotated[i][j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}