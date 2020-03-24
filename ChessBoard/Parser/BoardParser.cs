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
            TryConvertToUInt(args[0], out uint width);
            IsPositiveNumber(width);

            TryConvertToUInt(args[1], out uint height);
            IsPositiveNumber(height);

            return new Board(width, height);
        }

        private void TryConvertToUInt(string str, out uint size)
        {
            if (!uint.TryParse(str, out size))
                throw new ArgumentException($"Can't convert '{size}' to int.");
        }

        private void IsPositiveNumber(uint number)
        {
            if (number < 0)
                throw new ArgumentException($"Number {number} must be greather than '0'");
        }
    }
}