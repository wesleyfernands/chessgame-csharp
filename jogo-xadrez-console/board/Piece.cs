using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board
{
    abstract class Piece
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

        public bool PredictPossibleMoviments()
        {
            bool[,] mat = PossibleMoviments();
            for (int i = 0; i < Board.Rows; i++)
            {
                for (int j = 0; j < Board.Columns; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CanMoveTo(Position pos)
        {
            return PossibleMoviments()[pos.Row, pos.Column];
        }

        public abstract bool[,] PossibleMoviments();
    }
}
