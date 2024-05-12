using System;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
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
        public void TestRunSuccessful()
        {
            // This test verifies if the test run was successful
            // If this test fails, it means there was an issue with the test run itself
            Assert.Pass("Test Run Successful.");
        }
    }
}
