using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            {
                var currentSquare = board.FindPiece(this);

                List<Square> moves = new List<Square>();

                int minMove = -1;
                int maxMove = 8;
                
                // 2D Array for Potential Moves
                int[,] knightMoves = { { -2, 1 }, { -1, 2 }, { 1, 2 }, { 2, 1 }, { 2, -1 }, { 1, -2 }, { -1, -2 }, { -2, -1 } };

                for (int i = 0; i < 8; i++)
                {
                    if (currentSquare.Row + knightMoves[i, 0] < maxMove && currentSquare.Row + knightMoves[i, 0] > minMove && currentSquare.Row + knightMoves[i, 1] < maxMove && currentSquare.Row + knightMoves[i, 1] > minMove)
                    {
                        moves.Add(new Square(currentSquare.Row + knightMoves[i, 0], currentSquare.Col + knightMoves[i, 1]));
                    }
                }
                return moves;
            }
        }
    }
}