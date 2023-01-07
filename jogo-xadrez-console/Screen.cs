using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board;
using jogo_xadrez_console.board.Enums;

namespace jogo_xadrez_console
{
    internal class Screen
    {
        public static void PrintBoard(Board board)
        {
            // Percorrer Matriz
            for (int i=0; i < board.Rows; i++ )
            {
                Console.Write(8 - i + " ");
                for(int j=0; j < board.Columns; j++ )
                {
                    if(board.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(board.Piece(i , j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void PrintPiece(Piece piece)
        {
            if(piece.Color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }

   
}
