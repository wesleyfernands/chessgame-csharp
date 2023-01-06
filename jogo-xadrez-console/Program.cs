using board;
using System;

namespace JogoXadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            Console.WriteLine($"Testando classe, Quantidade de Linhas: " + board.Rows + ", Colunas: " + board.Columns);
        }
    }
}