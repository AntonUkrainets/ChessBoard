using ChessBoard.Model;
using Xunit;

namespace ChessBoardTests.Model
{
    public class BoardTests
    {
        [Theory]
        [InlineData(1, 2)]
        public void Ctor(int width, int height)
        {
            // Act
            var board = new Board(width, height);

            // Assert
            Assert.Equal(width, board.Width);
            Assert.Equal(height, board.Height);
        }
    }
}