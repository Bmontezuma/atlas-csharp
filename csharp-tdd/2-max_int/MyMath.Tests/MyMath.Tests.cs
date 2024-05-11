using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void Max_ValidList_ReturnsMaxNum()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            int expected = 5;

            int result = Operations.Max(nums);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            int expected = 0;

            int result = Operations.Max(nums);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            List<int> nums = null;
            int expected = 0;

            int result = Operations.Max(nums);

            Assert.AreEqual(expected, result);
        }
    }
}
