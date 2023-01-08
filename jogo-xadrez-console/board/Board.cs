using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board
{
    internal class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Piece[,] Pieces;

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[Rows, Columns];
        }

        public Piece Piece(int row, int column)
        {
            return Pieces[row, column];
        }

        public Piece Piece(Position pos) // Sobrecarga de metodo
        {
            return Pieces[pos.Row, pos.Column];
        }
        public bool PieceExists(Position pos)
        {
            ValidatePosition(pos);
            return Piece(pos) != null;
        }

        public void PutPiece(Piece p, Position pos)
        {
            if (PieceExists(pos))
            {
                throw new BoardException("Já existe uma peça nessa posição!");
            }
            Pieces[pos.Row, pos.Column] = p;
            p.Position = pos;
        }

        public Piece RemovePiece(Position pos)
        {
            if(Piece(pos) == null)
            {
                return null;
            }
            Piece aux = Piece(pos);
            aux.Position = null;
            Pieces[pos.Row, pos.Column] = null;
            return aux;
        }

        public bool PositionValid(Position pos)
        {
            if(pos.Row < 0 || pos.Row >= Rows || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidatePosition(Position pos) // Lançar exceções
        {
            if(!PositionValid(pos))
            {
                throw new BoardException("Posição inválida!");
            }
        }
    }
}
