using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary> Test Class of Operations </summary>
    [TestFixture]
    public class OpTests
    {
        [Test]
        public void IsCorrect()
        {
            int a = 1;
            int b = 2;

            int result = Operations.Add(a, b);
            Assert.AreEqual(3, result);
        }
        
        [Test]
        public void NegativeNums()
        {
            int a = -1;
            int b = -3;

            int result = Operations.Add(a, b);
            Assert.AreEqual(-4, result);
        }

        [Test]
        public void PositiveAndNegativeNums()
        {
            int a = 1;
            int b = -2;

            int result = Operations.Add(a, b);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void AddingZeros()
        {
            int a = 0;
            int b = 0;

            int result = Operations.Add(a, b);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void BigSum()
        {
            int a = 100000;
            int b = 200000;

            int result = Operations.Add(a, b);
            Assert.AreEqual(300000, result);
        }
    }
}
