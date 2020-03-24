using ChessBoard.Model;

namespace ChessBoard.Parser.Interfaces
{
    public interface IParser
    {
        bool CanParse(string[] args);
        Board Parse(string[] args);
    }
}