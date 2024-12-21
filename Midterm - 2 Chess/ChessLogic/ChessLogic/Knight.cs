// Knight.cs
using System.Collections.Generic;

namespace ChessGame
{
    public class Knight : ChessPiece
    {
        public Knight(PieceColor color, (int X, int Y) position) : base("Knight", color, position) { }

        public override List<(int X, int Y)> GetLegalMoves(Board board)
        {
            var moves = new List<(int X, int Y)>();
            foreach (var offset in new[] { (2, 1), (1, 2), (-1, 2), (-2, 1), (-2, -1), (-1, -2), (1, -2), (2, -1) })
            {
                var newPosition = (Position.X + offset.Item1, Position.Y + offset.Item2);
                if (board.IsInsideBoard(newPosition) && (!board.IsOccupied(newPosition) || board.IsOccupiedByOpponent(newPosition, Color)))
                    moves.Add(newPosition);
            }
            return moves;
        }
    }
}