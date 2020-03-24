using ChessBoard.Business.Interfaces;
using ChessBoard.Model;

namespace ChessBoard.Business.Generator
{
    public class EmptyBoardGenerator : IBoardGenerator
    {
        public bool CanGenerate(uint width, uint height)
        {
            return width > 0
                && height > 0;
        }

        public Board Generate(uint width, uint height)
        {
            return new Board(width, height);
        }
    }
}