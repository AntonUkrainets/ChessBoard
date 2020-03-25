using ChessBoard.Business.Interfaces;
using ChessBoard.Model;
using ChessBoard.Pieces;

namespace ChessBoard.Business.Generator
{
    public class ChessBoardGenerator : IBoardGenerator
    {
        public bool CanGenerate(int width, int height)
        {
            return width == 8
                && height == 8;
        }

        public Board Generate(int width, int height)
        {
            var board = new Board(width, height);

            var pieces = new IPiece[]
            {
                new WhitePieces(),
                new BlackPieces()
            };

            board[0, 0] = pieces[1].Rook;
            board[1, 0] = pieces[1].Knight;
            board[2, 0] = pieces[1].Bishop;
            board[3, 0] = pieces[1].King;
            board[4, 0] = pieces[1].Queen;
            board[5, 0] = pieces[1].Bishop;
            board[6, 0] = pieces[1].Knight;
            board[7, 0] = pieces[1].Rook;

            board[0, 1] = pieces[1].Pawn;
            board[1, 1] = pieces[1].Pawn;
            board[2, 1] = pieces[1].Pawn;
            board[3, 1] = pieces[1].Pawn;
            board[4, 1] = pieces[1].Pawn;
            board[5, 1] = pieces[1].Pawn;
            board[6, 1] = pieces[1].Pawn;
            board[7, 1] = pieces[1].Pawn;

            board[0, 6] = pieces[0].Pawn;
            board[1, 6] = pieces[0].Pawn;
            board[2, 6] = pieces[0].Pawn;
            board[3, 6] = pieces[0].Pawn;
            board[4, 6] = pieces[0].Pawn;
            board[5, 6] = pieces[0].Pawn;
            board[6, 6] = pieces[0].Pawn;
            board[7, 6] = pieces[0].Pawn;

            board[0, 7] = pieces[0].Rook;
            board[1, 7] = pieces[0].Knight;
            board[2, 7] = pieces[0].Bishop;
            board[3, 7] = pieces[0].King;
            board[4, 7] = pieces[0].Queen;
            board[5, 7] = pieces[0].Bishop;
            board[6, 7] = pieces[0].Knight;
            board[7, 7] = pieces[0].Rook;

            return board;
        }
    }
}