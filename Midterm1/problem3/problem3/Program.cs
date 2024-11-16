namespace problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size: ");
            string size = Console.ReadLine();
            int length = int.Parse(size);
            char[,] matrix = new char[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    matrix[i, j] = '#';
                    Console.Write(matrix[i, j] + "   ");
                }
                Console.WriteLine();
            }
            while (true)
            {
                Console.WriteLine("Player1 enter row: ");
                int row = getCol(matrix);
                Console.WriteLine("Player1 enter column: ");
                int col = getCol(matrix);
                if (checkMove(matrix, row, col))
                {
                    matrix[row, col] = 'x';
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Invalid input try again: ");
                        row = getCol(matrix);
                        col = getCol(matrix);
                        if (checkMove(matrix, row, col))
                        {
                            matrix[row, col] = 'o';
                            break;
                        }
                    }
                }
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        Console.Write(matrix[i, j] + "   ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(checkForWinP1(matrix, row, col));
                if (checkForWinP1(matrix, row, col))
                {
                    Console.WriteLine("P1 win");
                    break;
                }
                Console.WriteLine("Player2 enter row: ");
                row = getCol(matrix);
                Console.WriteLine("Player2 enter column: ");
                col = getCol(matrix);
                if (checkMove(matrix, row, col))
                {
                    matrix[row, col] = 'o';
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Invalid input try again: ");
                        row = getCol(matrix);
                        col = getCol(matrix);
                        if (checkMove(matrix, row, col))
                        {
                            matrix[row, col] = 'o';
                            break;
                        }
                    }
                }
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        Console.Write(matrix[i, j] + "   ");
                    }
                    Console.WriteLine();
                }
                if (checkForWinP2(matrix, row, col))
                {
                    Console.WriteLine("P1 win");
                    break;
                }
            }

        }
        static int getRow(char[,] matrix)
        {
            string a = Console.ReadLine();
            int row = int.Parse(a);
            return row;
        }
        static int getCol(char[,] matrix)
        {
            string a = Console.ReadLine();
            int col = int.Parse(a);
            return col;
        }
        static bool checkMove(char[,] arr, int row, int col)
        {
            if (arr[row, col] == 'x' || arr[row, col] == 'o')
            {
                return false;
            }
            return true;
        }
        static bool checkForWinP2(char[,] arr, int row, int col)
        {
            int horizontal = 0;
            int vertical = 0;
            int diagonal = 0;
            int length = arr.GetLength(0);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i, col] == 'o') vertical++;
                if (arr[row, i] == 'o') horizontal++;
                if (arr[i, i] == 'o') diagonal++;
            }
            if (horizontal == length || vertical == length || diagonal == length)
            {
                return true;
            }
            return false;
        }

           static bool checkForWinP1(char[,] arr, int row, int col)
            {
                int horizontal = 0;
                int vertical = 0;
                int diagonal = 0;
                int length = arr.Length;
                Console.WriteLine( "col: " + col);
                Console.WriteLine("row " + row);
                for (int i = 0; i < length; i++)
                {
                    if (arr[i, col] == 'x') vertical++;
                    if (arr[row, i] == 'x') horizontal++;
                    if (arr[i, i] == 'x') diagonal++;

                }
                if (horizontal == length || vertical == length || diagonal == length)
                {
                    return true;
                }
                return false;
           }
    }
}
