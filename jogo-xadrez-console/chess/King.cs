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
    }
}
