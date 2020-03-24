using ChessBoard.Validation;
using Xunit;

namespace ChessBoardTests.Validation
{
    public class ValidatorTests
    {
        [Theory]
        [InlineData("1", "2")]
        [InlineData("a", "b")]
        public void IsArgumentsValid_Positive(params string[] args)
        {
            // Act
            var actualValue = Validator.IsArgumentsValid(args);

            // Assert
            Assert.True(actualValue);
        }

        [Theory]
        [InlineData("1")]
        [InlineData("a", "b", "c")]
        public void IsArgumentsValid_Negative(params string[] args)
        {
            // Act
            var actualValue = Validator.IsArgumentsValid(args);

            // Assert
            Assert.False(actualValue);
        }
    }
}