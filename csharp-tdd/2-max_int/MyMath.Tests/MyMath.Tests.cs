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
            List<int> nums = new List<int> { 1, 3, 4, 5, 7, 9 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Max_ListWithNegativeIntegers_ReturnsMaxInteger()
        {
            // Arrange
            List<int> nums = new List<int> { -20, -17, -8, -1 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Max_ListWithMixedIntegers_ReturnsMaxInteger()
        {
            // Arrange
            List<int> nums = new List<int> { 98, -972, 1024, 42, 0, -727, 1 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(1024, result);
        }

        [Test]
        public void Max_ListWithDuplicates_ReturnsMaxInteger()
        {
            // Arrange
            List<int> nums = new List<int> { 98, -972, 1024, 42, 0, -727, 1, 98, 1, -972, 1024, 42, 42 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(1024, result);
        }

        [Test]
        public void Max_MaxAtEnd_ReturnsMaxInteger()
        {
            // Arrange
            List<int> nums = new List<int> { 3, 9, 0, 1, 2, 7 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Max_MaxAtBeginning_ReturnsMaxInteger()
        {
            // Arrange
            List<int> nums = new List<int> { 1024, 42, 0, -727, 1 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(1024, result);
        }

        [Test]
        public void Max_MaxInMiddle_ReturnsMaxInteger()
        {
            // Arrange
            List<int> nums = new List<int> { -8, -17, -100, -20 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(-8, result);
        }
    }
}
