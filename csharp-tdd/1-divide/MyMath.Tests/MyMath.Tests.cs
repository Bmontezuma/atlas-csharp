using NUnit.Framework;
using MyMath;
using System;

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
            using (var consoleOutput = new ConsoleOutput())
            {
                int[,] result = Matrix.Divide(matrix, num);

                // Checking if the error message was printed
                Assert.That(consoleOutput.GetOuput(), Does.Contain("Num cannot be 0"));

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

        // Custom ConsoleOutput class to redirect console output
        public class ConsoleOutput : IDisposable
        {
            private readonly System.IO.StringWriter stringWriter;
            private readonly System.IO.TextWriter originalOutput;

            public ConsoleOutput()
            {
                stringWriter = new System.IO.StringWriter();
                originalOutput = Console.Out;
                Console.SetOut(stringWriter);
            }

            public string GetOuput()
            {
                return stringWriter.ToString();
            }

            public void Dispose()
            {
                stringWriter.Dispose();
                Console.SetOut(originalOutput);
            }
        }
    }
}
