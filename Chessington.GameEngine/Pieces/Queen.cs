using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            
            List<Square> moves = new List<Square>();

            int minMove = -1;
            int maxMove = 8;
            
            for (int col = currentSquare.Col + 1, row = currentSquare.Row + 1; col < maxMove && row < maxMove; row++, col++)
            {
                moves.Add(new Square(row, col));
            }

            for (int col = currentSquare.Col - 1, row = currentSquare.Row + 1; col > minMove && row < maxMove; row++, col--)
            {
                moves.Add(new Square(row, col));
            }

            for (int col = currentSquare.Col - 1, row = currentSquare.Row - 1; col > minMove && row > minMove; row--, col--)
            {
                moves.Add(new Square(row, col));
            }

            for (int col = currentSquare.Col + 1, row = currentSquare.Row - 1; col < maxMove && row > minMove; row--, col++)
            {
                moves.Add(new Square(row, col));
            }

            for (var i = 0; i < 8; i++)
            {
                moves.Add(Square.At(currentSquare.Row, i));
            }

            for (var i = 0; i < 8; i++)
            {
                moves.Add(Square.At(i, currentSquare.Col));
                moves.RemoveAll(s => s == Square.At(currentSquare.Row, currentSquare.Col));
            }
            return moves;
        }
    }
}