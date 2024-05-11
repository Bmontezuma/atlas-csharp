using NUnit.Framework;
using MyMath;
using System;
using System.IO;

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

            // Redirecting console output to capture the printed error message
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                int[,] result = Matrix.Divide(matrix, num);

                string printedMessage = sw.ToString();

                // Checking if the error message was printed
                Assert.That(printedMessage, Does.Contain("Num cannot be 0"));

                // Checking if the result is null
                Assert.IsNull(result);
            }
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
        public void TestOutput_DoesNotContain_SuccessfulMessage()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Perform any action that may print "Test Run Successful."

                string printedMessage = sw.ToString();

                // Checking if the printed message does not contain "Test Run Successful."
                Assert.That(printedMessage, Does.Not.Contain("Test Run Successful."));
            }
        }
    }
}
