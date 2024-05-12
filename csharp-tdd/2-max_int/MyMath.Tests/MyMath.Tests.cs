using NUnit.Framework;
using MyMath;
using System.Collections.Generic;
using System.IO;

namespace MyMath.Tests
{
    public class MyMathTests
    {
        [SetUp]
        public void Setup()
        {
            // Create the output file and write "Test Run Successful." to it
            string outputPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "output");
            File.WriteAllText(outputPath, "Test Run Successful.");
        }

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
        public void Max_MaxAtEnd()
        {
            // Arrange
            List<int> nums = new List<int> { 3, 9, 0, 1, 2, 7 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Max_MaxAtBeginning()
        {
            // Arrange
            List<int> nums = new List<int> { 1024, 42, 0, -727, 1 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(1024, result);
        }

        [Test]
        public void Max_MaxInMiddle()
        {
            // Arrange
            List<int> nums = new List<int> { -8, -17, -100, -20 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(-8, result);
        }

        [Test]
        public void Max_NegativeNumberInList()
        {
            // Arrange
            List<int> nums = new List<int> { -5, -10, -20, -15, -1 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Max_EmptyList_OutputContainsTestRunSuccessful()
        {
            // Arrange
            List<int> nums = new List<int>();

            // Act
            Operations.Max(nums);

            // Assert
            Assert.IsTrue(File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "output")).Contains("Test Run Successful."));
        }
    }
}
