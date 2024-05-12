using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void CamelCase_InputNull_ReturnsZero()
        {
            // Arrange
            string input = null;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_InputEmpty_ReturnsZero()
        {
            // Arrange
            string input = "";

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            // Arrange
            string input = "hello";

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            // Arrange
            string input = "helloWorld";

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void CamelCase_MultipleWords_ReturnsCorrectCount()
        {
            // Arrange
            string input = "helloWorldHowAreYou";

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}
