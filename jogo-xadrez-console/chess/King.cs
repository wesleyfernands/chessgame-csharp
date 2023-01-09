using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using board;
using jogo_xadrez_console.board.Enums;

namespace chess
{
    internal class King : Piece
    {
        public King(Board board, Color color) : base(board, color) 
        {
        }

        public override string ToString()
        {
            return "R";
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

            // Norte - North 
            pos.SetValues(Position.Row - 1, Position.Column);
            if(Board.PositionValid(pos) && CanMove(pos))
            {
                matriz[pos.Row, pos.Column] = true;
            }
            // Nordeste - NorthEast
            pos.SetValues(Position.Row - 1, Position.Column + 1);
            if (Board.PositionValid(pos) && CanMove(pos))
            {
                matriz[pos.Row, pos.Column] = true;
            }
            // Leste - East
            pos.SetValues(Position.Row, Position.Column + 1);
            if (Board.PositionValid(pos) && CanMove(pos))
            {
                matriz[pos.Row, pos.Column] = true;
            }
            // Sudeste - SouthEast
            pos.SetValues(Position.Row + 1, Position.Column + 1);
            if (Board.PositionValid(pos) && CanMove(pos))
            {
                matriz[pos.Row, pos.Column] = true;
            }
            // Sul - South
            pos.SetValues(Position.Row + 1, Position.Column);
            if (Board.PositionValid(pos) && CanMove(pos))
            {
                matriz[pos.Row, pos.Column] = true;
            }
            // Sudoeste - SouthWest
            pos.SetValues(Position.Row + 1, Position.Column - 1);
            if (Board.PositionValid(pos) && CanMove(pos))
            {
                matriz[pos.Row, pos.Column] = true;
            }
            // Oeste - West
            pos.SetValues(Position.Row, Position.Column - 1);
            if (Board.PositionValid(pos) && CanMove(pos))
            {
                matriz[pos.Row, pos.Column] = true;
            }
            //Noroeste - NorthWest
            pos.SetValues(Position.Row - 1, Position.Column - 1);
            if (Board.PositionValid(pos) && CanMove(pos))
            {
                matriz[pos.Row, pos.Column] = true;
            }
            return matriz;
        }
    }
}
