using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Pawn : ChessPiece
    {

        public Pawn(PlayerColor color, (int X, int Y) position) : base("Pawn", position, color) { }

        public override List<(int X, int Y)> GetLegalMoves(Board board)
        {
            var moves = new List<(int X, int Y)>();
            int direction = 0;
            if(Color == PlayerColor.White) direction = -1;
            else if(Color == PlayerColor.Black) direction = 1;
            var newPosition = (Position.X, Position.Y + direction);

            if (board.IsInsideBoard(newPosition) && !board.IsOccupied(newPosition))
                moves.Add(newPosition);

            foreach (var attackOffset in new[] { -1, 1 })
            {
                var attackPosition = (Position.X + attackOffset, Position.Y + direction);
                if (board.IsInsideBoard(attackPosition) && board.IsOccupiedByOpponent(attackPosition, Color))
                    moves.Add(attackPosition);
            }

            return moves;
        }
    }
}
