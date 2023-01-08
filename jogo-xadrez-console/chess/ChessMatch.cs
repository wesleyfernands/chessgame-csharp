using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using board;
using jogo_xadrez_console.board.Enums;

namespace chess
{
    internal class ChessMatch
    {
        public Board Board { get; private set; }
        private int Turn;
        private Color CurrentPlayer;
        public bool Finished { get; private set; }

        public ChessMatch()
        {
            Board = new Board(8, 8);
            Turn = 1;
            CurrentPlayer = Color.White;
            Finished = false;
            PutPieces();
        }

        public void ExecuteMovement(Position origin, Position destiny)
        {
            Piece p = Board.RemovePiece(origin);
            p.IncrementQtyMoviments();
            Piece CapturedPiece = Board.RemovePiece(destiny);
            Board.PutPiece(p, destiny);
        }

        private void PutPieces()
        {
            Board.PutPiece(new Tower(Board, Color.White), new ChessPosition('c', 1).ToPosition());
            Board.PutPiece(new Tower(Board, Color.White), new ChessPosition('c', 2).ToPosition());
            Board.PutPiece(new Tower(Board, Color.White), new ChessPosition('d', 2).ToPosition());
            Board.PutPiece(new Tower(Board, Color.White), new ChessPosition('e', 2).ToPosition());
            Board.PutPiece(new Tower(Board, Color.White), new ChessPosition('e', 1).ToPosition());
            Board.PutPiece(new King(Board, Color.White), new ChessPosition('d', 1).ToPosition());

            Board.PutPiece(new Tower(Board, Color.Blue), new ChessPosition('c', 7).ToPosition());
            Board.PutPiece(new Tower(Board, Color.Blue), new ChessPosition('c', 8).ToPosition());
            Board.PutPiece(new Tower(Board, Color.Blue), new ChessPosition('d', 7).ToPosition());
            Board.PutPiece(new Tower(Board, Color.Blue), new ChessPosition('e', 7).ToPosition());
            Board.PutPiece(new Tower(Board, Color.Blue), new ChessPosition('e', 8).ToPosition());
            Board.PutPiece(new King(Board, Color.Blue), new ChessPosition('d', 8).ToPosition());
        }
    }
}
