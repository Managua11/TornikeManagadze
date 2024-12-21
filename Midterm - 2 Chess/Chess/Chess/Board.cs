using System;

namespace Chess
{
    public class Board
    {
        public const int Size = 8;
        private readonly ChessPiece[,] _board;

        public Board()
        {
            _board = new ChessPiece[Size, Size];
        }

        public bool IsInsideBoard((int X, int Y) position) =>
            position.X >= 0 && position.X < Size && position.Y >= 0 && position.Y < Size;

        public bool IsOccupied((int X, int Y) position) =>
            _board[position.X, position.Y] != null;

        public bool IsOccupiedByOpponent((int X, int Y) position, PlayerColor color) =>
            IsOccupied(position) && _board[position.X, position.Y].Color != color;

        public ChessPiece GetPieceAt((int X, int Y) position) =>
            _board[position.X, position.Y];

        public void PlacePiece(ChessPiece piece)
        {
            _board[piece.Position.X, piece.Position.Y] = piece;
        }

        public void MovePiece((int X, int Y) from, (int X, int Y) to)
        {
            var piece = GetPieceAt(from);
            if (piece == null) throw new InvalidOperationException("No piece at the given position.");

            _board[to.X, to.Y] = piece;
            _board[from.X, from.Y] = null;
            piece.Position = to;
        }

        public void RemovePiece((int X, int Y) position)
        {
            _board[position.X, position.Y] = null;
        }
    }
}
