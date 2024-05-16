using System;
using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            // Arrange
            string s = "";

            // Act
            int result = Str.UniqueChar(s);

            // Assert
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void UniqueChar_AllRepeatingCharacters_ReturnsMinusOne()
        {
            // Arrange
            string s = "aaabbbccc";

            // Act
            int result = Str.UniqueChar(s);

            // Assert
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]