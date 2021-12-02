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
            var currentSquare = board.FindPiece(this);

            List<Square> moves = new List<Square>();

            // White moves up board, therefore subtract
            if(this.Player == Player.White)
            {
                moves.Add(new Square(currentSquare.Row -1 , currentSquare.Col));
            }

            // Black moves down board, so adds
            else if (this.Player == Player.Black)
            {
                moves.Add(new Square(currentSquare.Row + 1, currentSquare.Col));
            }

            return moves;
        }
    }
}