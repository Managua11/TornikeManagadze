using ChessLogic;
using System;

namespace ChessGame
{
    public static class Game
    {
        public static void Main()
        {
            var board = new Board();
            var playerColor = GetPlayerColor();
            InitializePieces(board, playerColor);

            while (true)
            {
                try
                {
                    DisplayBoard(board);
                    Console.WriteLine("Select a piece to move (format: x y):");
                    var from = ParsePosition(Console.ReadLine());
                    var piece = board.GetPieceAt(from);

                    if (piece == null || piece.Color != playerColor)
                    {
                        Console.WriteLine("Invalid piece selection. Try again.");
                        continue;
                    }

                    var legalMoves = piece.GetLegalMoves(board);
                    Console.WriteLine("Legal moves:");
                    foreach (var move in legalMoves)
                        Console.WriteLine($"({move.X}, {move.Y})");

                    Console.WriteLine("Enter destination (format: x y):");
                    var to = ParsePosition(Console.ReadLine());

                    if (!legalMoves.Contains(to))
                    {
                        Console.WriteLine("Illegal move. Try again.");
                        continue;
                    }

                    if (board.IsOccupiedByOpponent(to, playerColor))
                        board.RemovePiece(to);

                    board.MovePiece(from, to);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private static void InitializePieces(Board board, PieceColor playerColor)
        {
            int pawnRow = playerColor == PieceColor.White ? 1 : 6;
            int backRow = playerColor == PieceColor.White ? 0 : 7;
            int opponentPawnRow = playerColor == PieceColor.White ? 6 : 1;
            int opponentBackRow = playerColor == PieceColor.White ? 7 : 0;

            for (int i = 0; i < Board.Size; i++)
            {
                board.PlacePiece(new Pawn(playerColor, (i, pawnRow)));
                board.PlacePiece(new Pawn(playerColor == PieceColor.White ? PieceColor.Black : PieceColor.White, (i, opponentPawnRow)));
            }

            board.PlacePiece(new Bishop(playerColor, (2, backRow)));
            board.PlacePiece(new Bishop(playerColor, (5, backRow)));
            board.PlacePiece(new Bishop(playerColor == PieceColor.White ? PieceColor.Black : PieceColor.White, (5, opponentBackRow)));
            board.PlacePiece(new Bishop(playerColor == PieceColor.White ? PieceColor.Black : PieceColor.White, (2, opponentBackRow)));


            board.PlacePiece(new Knight(playerColor, (1, backRow)));
            board.PlacePiece(new Knight(playerColor, (6, backRow)));
            board.PlacePiece(new Knight(playerColor == PieceColor.White ? PieceColor.Black : PieceColor.White, (1, opponentBackRow)));
            board.PlacePiece(new Knight(playerColor == PieceColor.White ? PieceColor.Black : PieceColor.White, (6, opponentBackRow)));

            board.PlacePiece(new King(playerColor, (4, backRow)));
            board.PlacePiece(new King(playerColor == PieceColor.White ? PieceColor.Black : PieceColor.White, (4, opponentBackRow)));
        }

        private static PieceColor GetPlayerColor()
        {
            Console.WriteLine("Choose your color (White/Black):");
            while (true)
            {
                var input = Console.ReadLine()?.Trim().ToLower();
                if (input == "white") return PieceColor.White;
                if (input == "black") return PieceColor.Black;
                Console.WriteLine("Invalid choice. Please type 'White' or 'Black'.");
            }
        }

        private static (int X, int Y) ParsePosition(string input)
        {
            var parts = input.Split(' ');
            if (parts.Length != 2 ||
                !int.TryParse(parts[0], out int x) ||
                !int.TryParse(parts[1], out int y))
                throw new FormatException("Invalid position format.");

            return (x, y);
        }

        private static void DisplayBoard(Board board)
        {
            for (int y = Board.Size - 1; y >= 0; y--)
            {
                for (int x = 0; x < Board.Size; x++)
                {
                    var piece = board.GetPieceAt((x, y));
                    Console.Write(piece == null ? ". " : piece.Name[0] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

