using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void TestAdd5Random([Random(-100, 100, 5)] int a, [Random(-100, 100, 5)] int b)
        {
            Assert.AreEqual(a + b, MyMath.Operations.Add(a, b));
        }

        [Test]
        public void TestAdd1and0()
        {
            Assert.AreEqual(1, MyMath.Operations.Add(0, 1));
        }
    }
}
