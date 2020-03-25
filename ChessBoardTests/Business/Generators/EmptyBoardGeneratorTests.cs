using ChessBoard.Business.Generator;
using Xunit;

namespace ChessBoardTests.Business.Generators
{
    public class EmptyBoardGeneratorTests
    {
        #region Private Members

        private readonly EmptyBoardGenerator emptyBoardGenerator;

        #endregion

        public EmptyBoardGeneratorTests()
        {
            emptyBoardGenerator = new EmptyBoardGenerator();
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 20)]
        public void CanGenerate_Positive(int width, int height)
        {
            // Act
            var actualValue = emptyBoardGenerator.CanGenerate(width, height);

            // Assert
            Assert.True(actualValue);
        }

        [Theory]
        [InlineData(-1, -2)]
        [InlineData(10, -20)]
        public void CanGenerate_Negative(int width, int height)
        {
            // Act
            var actualValue = emptyBoardGenerator.CanGenerate(width, height);

            // Assert
            Assert.False(actualValue);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 20)]
        public void Generate(int width, int height)
        {
            // Act
            var actualValue = emptyBoardGenerator.Generate(width, height);

            // Assert
            Assert.Equal(width, actualValue.Width);
            Assert.Equal(height, actualValue.Height);
        }
    }
}