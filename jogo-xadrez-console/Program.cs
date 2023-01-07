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
            ChessPosition posXadrez = new ChessPosition('a', 1);

            Console.WriteLine(posXadrez);

            Console.WriteLine(posXadrez.ToPosition());

            Console.ReadLine();
        }
    }
}