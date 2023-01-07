using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board;

namespace jogo_xadrez_console
{
    internal class Screen
    {
        public static void PrintBoard(Board board)
        {
            // Percorrer Matriz
            for (int i=0; i < board.Rows; i++ )
            {
                for(int j=0; j < board.Columns; j++ )
                {
                    if(board.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.Piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
