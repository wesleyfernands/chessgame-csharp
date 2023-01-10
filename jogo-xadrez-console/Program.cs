using board;
using jogo_xadrez_console;
using System;
using chess;
using Enums;
using System.Text;


namespace JogoXadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessMatch match = new ChessMatch();

                while (!match.Finished)
                {
                    try
                    {
                        Console.Clear();
                        Screen.PrintBoard(match.Board);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + match.Turn);
                        Console.WriteLine("Aguardando jogada: " + match.CurrentPlayer);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Position origin = Screen.ReadChessPosition().ToPosition();
                        match.ValidatePositionOrigin(origin);

                        bool[,] possiblePositions = match.Board.Piece(origin).PossibleMoviments();

                        Console.Clear();
                        Screen.PrintBoard(match.Board, possiblePositions);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Position destiny = Screen.ReadChessPosition().ToPosition();
                        match.ValidatePositionDestiny(origin, destiny);

                        match.AccomplishMovement(origin, destiny);
                    }
                    catch (BoardException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}