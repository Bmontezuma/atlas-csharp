using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void RegularPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "Racecar";

            // Act
            bool result = Str.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void UpperLowerCaseLetters_ReturnsTrue()
        {
            // Arrange
            string input = "LeVel";

            // Act
            bool result = Str.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Punctuation_ReturnsTrue()
        {
            // Arrange
            string input = "A man, a plan, a canal: Panama.";

            // Act
            bool result = Str.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Spaces_ReturnsTrue()
        {
            // Arrange
            string input = "taco cat";

            // Act
            bool result = Str.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void EmptyString_ReturnsTrue()
        {
            // Arrange
            string input = "";

            // Act
            bool result = Str.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
