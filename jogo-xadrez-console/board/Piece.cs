using jogo_xadrez_console.board.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board
{
    internal abstract class Piece
    {
        public Position Position { get; set; } 
        public Color Color { get; protected set; } // enum
        public int QtyMoviments { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Board board, Color color)
        {
            Position = null;
            Board = board;
            Color = color;
            QtyMoviments = 0;
        }

        public void IncrementQtyMoviments()
        {
            QtyMoviments++;
        }

        public abstract bool[,] PossibleMoviments();
    }
}
