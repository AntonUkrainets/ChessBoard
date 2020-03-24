using ChessBoard.Model;

namespace ChessBoard.Business.Interfaces
{
    public interface IBoardGenerator
    {
        bool CanGenerate(uint width, uint height);
        Board Generate(uint width, uint height);
    }
}