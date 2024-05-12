using NUnit.Framework;
using MyMath;

namespace MathTests
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void AddingTwoPositiveNumbers()
        {
            // Arrange
            int firstNumber = 1;
            int secondNumber = 2;
            int expectedResult = 3;

            // Act
            int result = Operations.Add(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expectedResult, result, $"Adding {firstNumber} and {secondNumber} should equal {expectedResult}");
        }

        [Test]
        public void AddingTwoNegativeNumbers()
        {
            // Arrange
            int firstNumber = -1;
            int secondNumber = -2;
            int expectedResult = -3;

            // Act
            int result = Operations.Add(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expectedResult, result, $"Adding {firstNumber} and {secondNumber} should equal {expectedResult}");
        }

        [Test]
        public void AddingTwoZeroNumbers()
        {
            // Arrange
            int firstNumber = 0;
            int secondNumber = 0;
            int expectedResult = 0;

            // Act
            int result = Operations.Add(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expectedResult, result, $"Adding {firstNumber} and {secondNumber} should equal {expectedResult}");
        }

        [Test]
        public void AddingOnePositiveAndOneNegativeNumber()
        {
            // Arrange
            int positiveNumber = 1;
            int negativeNumber = -2;
            int expectedResult = -1;

            // Act
            int result = Operations.Add(positiveNumber, negativeNumber);

            // Assert
            Assert.AreEqual(expectedResult, result, $"Adding {positiveNumber} and {negativeNumber} should equal {expectedResult}");
        }
    }
}
