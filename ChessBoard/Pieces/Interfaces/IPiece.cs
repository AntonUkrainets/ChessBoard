namespace ChessBoard.Pieces
{
    public interface IPiece
    {
        char King { get; }

        char Queen { get; }

        char Rook { get; }

        char Bishop { get; }

        char Knight { get; }

        char Pawn { get; }
    }
}