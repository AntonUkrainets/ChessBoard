using ChessBoard.Business.Interfaces;
using ChessBoard.Model;

namespace ChessBoard.Business.Generator
{
    public class EmptyBoardGenerator : IBoardGenerator
    {
        public bool CanGenerate(int width, int height)
        {
            return width > 0
                && height > 0;
        }

        public Board Generate(int width, int height)
        {
            return new Board(width, height);
        }
    }
}