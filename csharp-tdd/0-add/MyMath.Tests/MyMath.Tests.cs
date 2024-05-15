using Xunit;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        /// <summary>
        /// Tests the <see cref="Operations.Add"/> method to ensure it returns the correct sum of two integers.
        /// </summary>
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 7;
            int expectedSum = 12;

            // Act
            int actualSum = Operations.Add(a, b);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }
    }
}
