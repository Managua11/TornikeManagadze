using System.Collections.Generic;

namespace ChessGame
{
    public class Pawn : ChessPiece
{
    public Pawn(PieceColor color, (int X, int Y) position) : base("Pawn", color, position) { }

    public override List<(int X, int Y)> GetLegalMoves(Board board)
    {
        var moves = new List<(int X, int Y)>();
        int direction = Color == PieceColor.White ? 1 : -1;
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
