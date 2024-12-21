using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public abstract class ChessPiece
    {
        public string Name { get; }
        public (int X, int Y) Position { get; set; }

        public PlayerColor Color { get; }

        public ChessPiece(string name, (int X, int Y) pos, PlayerColor color) {
            this.Color = color;
            this.Position = pos;

        }

        public abstract List<(int X, int Y)> GetLegalMoves(Board board);
    }
}
