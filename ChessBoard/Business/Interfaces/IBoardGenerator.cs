using ChessBoard.Model;

namespace ChessBoard.Business.Interfaces
{
    public interface IBoardGenerator
    {
        bool CanGenerate(int width, int height);
        Board Generate(int width, int height);
    }
}