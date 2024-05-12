using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void UniqueChar_FirstNonRepeating_ReturnsCorrectIndex()
        {
            // Arrange
            string input = "leetcode";

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniqueChar_NoNonRepeating_ReturnsMinusOne()
        {
            // Arrange
            string input = "aabbcc";

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

        [Test]
        public void UniqueChar_SingleCharacter_ReturnsZero()
        {
            // Arrange
            string input = "a";

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
