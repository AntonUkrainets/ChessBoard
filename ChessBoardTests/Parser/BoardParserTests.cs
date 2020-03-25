using System;
using ChessBoard.Parser;
using Xunit;

namespace ChessBoardTests.Parser
{
    public class BoardParserTests
    {
        #region Private Members

        private readonly BoardParser boardParser;

        #endregion

        public BoardParserTests()
        {
            boardParser = new BoardParser();
        }

        [Theory]
        [InlineData("1", "2")]
        [InlineData("a", "b")]
        public void CanParse_Positive(params string[] args)
        {
            // Act
            var actualValue = boardParser.CanParse(args);

            // Assert
            Assert.True(actualValue);
        }

        [Theory]
        [InlineData("1")]
        [InlineData("a", "b", "c")]
        public void CanParse_Negative(params string[] args)
        {
            // Act
            var actualValue = boardParser.CanParse(args);

            // Assert
            Assert.False(actualValue);
        }

        [Theory]
        [InlineData(1, 2, "1", "2")]
        public void Parse(
            int width,
            int height,
            params string[] args)
        {
            // Act
            var actualValue = boardParser.Parse(args);

            //Assert
            Assert.Equal(width, actualValue.Width);
            Assert.Equal(height, actualValue.Height);
        }

        [Theory]
        [InlineData("a", "b")]
        public void Parse_TryConvertToInt(params string[] args)
        {
            //Assert
            Assert.Throws<ArgumentException>(() => boardParser.Parse(args));
        }

        [Theory]
        [InlineData("-1", "-2")]
        public void Parse_IsPositiveNumber(params string[] args)
        {
            //Assert
            Assert.Throws<ArgumentException>(() => boardParser.Parse(args));
        }
    }
}