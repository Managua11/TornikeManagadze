// ChessPiece.cs
using System;
using System.Collections.Generic;

namespace ChessGame
{
    public abstract class ChessPiece
    {
        public string Name { get; }
        public PieceColor Color { get; }
        public (int X, int Y) Position { get; set; }

        protected ChessPiece(string name, PieceColor color, (int X, int Y) position)
        {
            Name = name;
            Color = color;
            Position = position;
        }

        public abstract List<(int X, int Y)> GetLegalMoves(Board board);
    }
}
