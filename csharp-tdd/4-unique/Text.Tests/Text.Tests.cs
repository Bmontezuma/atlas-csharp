using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void UniqueChar_FirstUniqueIsFirstChar_ReturnsZero()
        {
            // Arrange
            string input = "helloworld";

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniqueChar_FirstUniqueIsLastChar_ReturnsCorrectIndex()
        {
            // Arrange
            string input = "helloholberton";

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void UniqueChar_FirstUniqueInMiddle_ReturnsCorrectIndex()
        {
            // Arrange
            string input = "aabbccddeef";

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void UniqueChar_NoUniqueCharacters_ReturnsMinusOne()
        {
            // Arrange
            string input = "hellohello";

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            // Arrange
            string input = "";

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.AreEqual(-1, result);
        }
    }
}
