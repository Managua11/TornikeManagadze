using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class King : ChessPiece
    {
        public King(PlayerColor color, (int X, int Y) position) : base("King", position, color) { }

        public override List<(int X, int Y)> GetLegalMoves(Board board)
        {
            var moves = new List<(int X, int Y)>();
            foreach (var offset in new[] { (1, 1), (1, 0), (1, -1), (0, 1), (0, -1), (-1, 1), (-1, 0), (-1, -1) })
            {
                var newPosition = (Position.X + offset.Item1, Position.Y + offset.Item2);
                if (board.IsInsideBoard(newPosition) && (!board.IsOccupied(newPosition) || board.IsOccupiedByOpponent(newPosition, Color)))
                    moves.Add(newPosition);
            }
            return moves;
        }
    }
}
