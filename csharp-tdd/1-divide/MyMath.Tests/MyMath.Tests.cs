using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Test]
        public void Divide_ValidMatrixAndNum_ReturnsDividedMatrix()
        {
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };
            int num = 2;
            int[,] expected = new int[,] { { 0, 1 }, { 1, 2 } };

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] matrix = null;
            int num = 2;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.IsNull(result);
        }

        [Test]
        public void Divide_ZeroNum_ReturnsNull()
        {
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };
            int num = 0;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.IsNull(result);
        }

        [Test]
        public void Divide_DivideByZero_ReturnsNull()
        {
            int[,] matrix = new int[,] { { 1, 0 }, { 3, 4 } };
            int num = 0;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.IsNull(result);
        }
    }
}
