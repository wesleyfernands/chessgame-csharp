using board;
using jogo_xadrez_console;
using System;

namespace JogoXadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            Screen.PrintBoard(board);
           
            Console.ReadLine();
        }
    }
}