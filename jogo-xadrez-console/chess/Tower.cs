using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using board;
using Enums;

namespace chess
{
    internal class Tower : Piece
    {
        public Tower(Board board, Color color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "T";
        }
        private bool CanMove(Position pos)
        {
            Piece p = Board.Piece(pos);
            return p == null || p.Color != Color;
        }

        public override bool[,] PossibleMoviments()
        {
            bool[,] matriz = new bool[Board.Rows, Board.Columns];

            Position pos = new Position(0, 0);

            // Norte
            pos.SetValues(Position.Row - 1, Position.Column);
            while (Board.PositionValid(pos) && CanMove(pos))
            {
                matriz[pos.Row, pos.Column] = true;
                if(Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.Row = pos.Row - 1;
            }
            //Sul
            pos.SetValues(Position.Row + 1, Position.Column);
            while (Board.PositionValid(pos) && CanMove(pos))
            {
                matriz[pos.Row, pos.Column] = true;
                if (Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.Row = pos.Row + 1;
            }
            // Leste
            pos.SetValues(Position.Row, Position.Column + 1);
            while (Board.PositionValid(pos) && CanMove(pos))
            {
                matriz[pos.Row, pos.Column] = true;
                if (Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.Row = pos.Row + 1;
            }
            // Oeste
            pos.SetValues(Position.Row, Position.Column - 1);
            while (Board.PositionValid(pos) && CanMove(pos))
            {
                matriz[pos.Row, pos.Column] = true;
                if (Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.Row = pos.Row - 1;
            }
            return matriz;
        }
    }
}