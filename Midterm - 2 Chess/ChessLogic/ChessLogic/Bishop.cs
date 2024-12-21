using ChessGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Bishop : ChessPiece
    {
        public Bishop(PieceColor color, (int X, int Y) position) : base("Bishop", color, position) { }

        public override List<(int X, int Y)> GetLegalMoves(Board board)
        {
            var moves = new List<(int X, int Y)>();
            foreach (var direction in new[] { (1, 1), (-1, 1), (-1, -1), (1, -1) })
            {
                var current = Position;
                while (true)
                {
                    current = (current.X + direction.Item1, current.Y + direction.Item2);
                    if (!board.IsInsideBoard(current)) break;
                    if (board.IsOccupied(current))
                    {
                        if (board.IsOccupiedByOpponent(current, Color))
                            moves.Add(current);
                        break;
                    }
                    moves.Add(current);
                }
                
            }
            return moves;
        }
    }
}
