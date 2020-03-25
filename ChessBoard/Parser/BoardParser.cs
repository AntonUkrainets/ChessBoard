using System;
using ChessBoard.Model;
using ChessBoard.Parser.Interfaces;

namespace ChessBoard.Parser
{
    public class BoardParser : IParser
    {
        public bool CanParse(string[] args)
        {
            return args.Length == 2;
        }

        public Board Parse(string[] args)
        {
            TryConvertToInt(args[0], out int width);
            IsPositiveNumber(width);

            TryConvertToInt(args[1], out int height);
            IsPositiveNumber(height);

            return new Board(width, height);
        }

        private void TryConvertToInt(string str, out int size)
        {
            if (!int.TryParse(str, out size))
                throw new ArgumentException($"Can't convert '{size}' to int.");
        }

        private void IsPositiveNumber(int number)
        {
            if (number < 0)
                throw new ArgumentException($"Number {number} must be greather than '0'");
        }
    }
}