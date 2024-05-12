using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            // Arrange
            List<int> nums = new List<int>();

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_ListWithPositiveIntegers_ReturnsMaxInteger()
        {
            // Arrange
            List<int> nums = new List<int> { 3, 7, 2, 9, 5 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Max_ListWithNegativeIntegers_ReturnsMaxInteger()
        {
            // Arrange
            List<int> nums = new List<int> { -3, -7, -2, -9, -5 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(-2, result);
        }

        // Add more test cases as needed to cover edge cases and scenarios
    }
}
