using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        /// <summary>
        /// Tests the Divide method with a valid matrix.
        /// </summary>
        [Test]
        public void Divide_ValidMatrix_ReturnsDividedMatrix()
        {
            int[,] matrix = new int[,] { { 2, 4, 6 }, { 8, 10, 12 }, { 14, 16, 18 } };
            int num = 2;
            int[,] expected = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the Divide method with a matrix that contains a 0.
        /// </summary>
        [Test]
        public void Divide_MatrixWithZero_ReturnsNull()
        {
            int[,] matrix = new int[,] { { 2, 4, 6 }, { 8, 0, 12 }, { 14, 16, 18 } };
            int num = 2;
            int[,] expected = null;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the Divide method with a null matrix.
        /// </summary>
        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] matrix = null;
            int num = 2;
            int[,] expected = null;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the Divide method with a 0 divisor.
        /// </summary>
        [Test]
        public void Divide_ZeroDivisor_PrintsErrorMessage()
        {
            int[,] matrix = new int[,] { { 2, 4, 6 }, { 8, 10, 12 }, { 14, 16, 18 } };
            int num = 0;
            int[,] expected = null;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
            Assert.AreEqual("Num cannot be 0", Console.LastLineWritten);
        }
    }
}
