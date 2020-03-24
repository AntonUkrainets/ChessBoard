using System;
using System.Linq;
using System.Text;
using ChessBoard.Business;
using ChessBoard.Business.Generator;
using ChessBoard.Business.Interfaces;
using ChessBoard.ConsoleManagers;
using ChessBoard.Parser;
using ChessBoard.Validation;

namespace ChessBoard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var consoleManager = new ConsoleManager();

            var fontStyle = "MS Gothic";
            consoleManager.SetFont(fontStyle);

            if (!Validator.IsArgumentsValid(args))
                throw new FormatException("Arguments must be in format <widthBoard> <heightBoard");

            var parser = new BoardParser();
            var board = parser.Parse(args);

            var boardGenerators = new IBoardGenerator[]
            {
                new ChessBoardGenerator(),
                new EmptyBoardGenerator()
            };

            var boardGenerator = boardGenerators
                .FirstOrDefault(b => b.CanGenerate(board.Width, board.Height));

            var drawableBoard = boardGenerator.Generate(board.Width, board.Height);

            var chessBoard = new ConsoleBoard(consoleManager);
            chessBoard.Draw(drawableBoard);
        }
    }
}