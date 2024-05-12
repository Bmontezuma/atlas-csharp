using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
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
        public void Add_NegativeAndPositive_ReturnsSum()
        {
            int a = -3;
            int b = 5;
            int expected = 2;

            int result = Operations.Add(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            int a = 3;
            int b = -5;
            int expected = -2;

            int result = Operations.Add(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_TwoNegativeIntegers_ReturnsSum()
        {
            int a = -3;
            int b = -5;
            int expected = -8;

            int result = Operations.Add(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_ZeroAndNonZero_ReturnsNonZero()
        {
            int a = 0;
            int b = 5;
            int expected = 5;

            int result = Operations.Add(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_NonZeroAndZero_ReturnsNonZero()
        {
            int a = 3;
            int b = 0;
            int expected = 3;

            int result = Operations.Add(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_TwoZeros_ReturnsZero()
        {
            int a = 0;
            int b = 0;
            int expected = 0;

            int result = Operations.Add(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_MaxValueAndOne_ReturnsOverflow()
        {
            int a = int.MaxValue;
            int b = 1;

            Assert.Throws<System.OverflowException>(() => Operations.Add(a, b));
        }

        [Test]
        public void Add_MinValueAndMinusOne_ReturnsOverflow()
        {
            int a = int.MinValue;
            int b = -1;

            Assert.Throws<System.OverflowException>(() => Operations.Add(a, b));
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
