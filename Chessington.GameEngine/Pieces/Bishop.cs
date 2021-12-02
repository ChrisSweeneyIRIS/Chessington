using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);

            List<Square> moves = new List<Square>();
            
            int minMoves = -1;
            int maxMoves = 8;
            

            for (int col = currentSquare.Col + 1, row = currentSquare.Row + 1; col < maxMoves && row < maxMoves; row++, col++)
            {
                moves.Add(new Square(row, col));
            }

            for (int col = currentSquare.Col - 1, row = currentSquare.Row + 1; col > minMoves && row < maxMoves; row++, col--)
            {
                moves.Add(new Square(row, col));
            }

            for (int col = currentSquare.Col - 1, row = currentSquare.Row - 1; col > minMoves && row > minMoves; row--, col--)
            {
                moves.Add(new Square(row, col));
            }

            for (int col = currentSquare.Col + 1, row = currentSquare.Row - 1; col < maxMoves && row > minMoves; row--, col++)
            {
                moves.Add(new Square(row, col));
            }

            return moves;
        }
    }
}