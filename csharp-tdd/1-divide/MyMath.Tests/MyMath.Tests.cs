using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Test]
        public void Divide_ByNonZeroNumber_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            int num = 2;
            int[,] expected = { { 0, 1 }, { 1, 2 } };

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ByZero_PrintsErrorMessageAndReturnsNull()
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            int num = 0;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] matrix = null;
            int num = 2;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.IsNull(result);
        }
    }
}
