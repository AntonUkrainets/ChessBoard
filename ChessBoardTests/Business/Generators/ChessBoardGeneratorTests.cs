using ChessBoard.Business.Generator;
using Xunit;

namespace ChessBoardTests.Business.Generators
{
    public class ChessBoardGeneratorTests
    {
        #region Private Members

        private readonly ChessBoardGenerator chessBoardGenerator;

        #endregion

        public ChessBoardGeneratorTests()
        {
            chessBoardGenerator = new ChessBoardGenerator();
        }

        [Theory]
        [InlineData(8, 8)]
        public void CanGenerate_Positive(int width, int height)
        {
            // Act
            var actualValue = chessBoardGenerator.CanGenerate(width, height);

            // Assert
            Assert.True(actualValue);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(8, 9)]
        public void CanGenerate_Negative(int width, int height)
        {
            // Act
            var actualValue = chessBoardGenerator.CanGenerate(width, height);

            // Assert
            Assert.False(actualValue);
        }
    }
}