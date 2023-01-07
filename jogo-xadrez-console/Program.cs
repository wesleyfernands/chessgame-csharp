using board;
using jogo_xadrez_console;
using System;
using xadrez;
using jogo_xadrez_console.board.Enums;

namespace JogoXadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);

                board.PutPiece(new Tower(board, Color.Blue), new Position(0, 0));
                board.PutPiece(new Tower(board, Color.Blue), new Position(1, 3));
                board.PutPiece(new King(board, Color.White), new Position(0, 5));
                board.PutPiece(new Tower(board, Color.White), new Position(2, 0));

                Screen.PrintBoard(board);
            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}