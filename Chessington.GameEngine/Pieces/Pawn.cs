using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            int blackStart = 1;
            int whiteStart = 6;
            
            var currentSquare = board.FindPiece(this);

            List<Square> moves = new List<Square>();

            // White moves up board, therefore subtract
            if (this.Player == Player.White)
            {
                if (currentSquare.Row == whiteStart)
                {
                    moves.Add(new Square(currentSquare.Row - 1, currentSquare.Col));
                    // Ability to moves aditional spaces
                    moves.Add(new Square(currentSquare.Row - 2, currentSquare.Col));
                }
            else
                {
                    moves.Add(new Square(currentSquare.Row - 1, currentSquare.Col));
                }
            }

            // Black moves down board, so adds
            else
            {
                if (currentSquare.Row == blackStart)
                {
                    moves.Add(new Square(currentSquare.Row + 1, currentSquare.Col));
                    moves.Add(new Square(currentSquare.Row + 2, currentSquare.Col));
                }
                else
                {
                    moves.Add(new Square(currentSquare.Row + 1, currentSquare.Col));
                }
            }

            return moves;
        }
    }
}