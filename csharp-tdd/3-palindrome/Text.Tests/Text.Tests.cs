using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void IsPalindrome_Racecar_ReturnsTrue()
        {
            // Arrange
            string input = "Racecar";

            // Act
            bool result = Str.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_Level_ReturnsTrue()
        {
            // Arrange
            string input = "level";

            // Act
            bool result = Str.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_PanamaSentence_ReturnsTrue()
        {
            // Arrange
            string input = "A man, a plan, a canal: Panama.";

            // Act
            bool result = Str.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            // Arrange
            string input = "";

            // Act
            bool result = Str.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = "hello";

            // Act
            bool result = Str.IsPalindrome(input);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
