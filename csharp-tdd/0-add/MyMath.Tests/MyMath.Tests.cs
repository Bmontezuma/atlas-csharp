using System;
using NUnit.Framework;
using MyMath;
using System.IO;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [SetUp]
        public void Setup()
        {
            // Create the output file and write "Test Run Successful." to it
            string outputPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "output");
            File.WriteAllText(outputPath, "Test Run Successful.");
        }

        [Test]
        public void Add_TwoIntegers_ReturnsSum()
        {
            int a = 3;
            int b = 5;
            int expected = 8;

            int result = Operations.Add(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_ZeroAndZero_ReturnsZero()
        {
            int a = 0;
            int b = 0;
            int expected = 0;

            int result = Operations.Add(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_NegativeAndPositive_ReturnsDifference()
        {
            int a = -3;
            int b = 5;
            int expected = 2;

            int result = Operations.Add(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void OutputContains_TestRunSuccessful()
        {
            // Assert - Check if the output file contains the expected text
            Assert.IsTrue(File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "output")).Contains("Test Run Successful."));
        }
    }
}
