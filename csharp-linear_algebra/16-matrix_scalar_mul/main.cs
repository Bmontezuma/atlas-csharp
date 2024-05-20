using System;

namespace MatrixMathLibrary
{
    /// <summary>
    /// Provides a main program for testing matrix operations.
    /// </summary>
    public class MainProgram
    {
        /// <summary>
        /// Entry point of the program.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        public static void Main(string[] args)
        {
            // Call EntryPoint method to run tests
            EntryPoint(args);
        }

        /// <summary>
        /// Main entry point for executing tests.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        public static void EntryPoint(string[] args)
        {
            // Test cases
            // Test case 1
            double[,] matrix1 = { { -2, 1 }, { 7, 9 } };
            double scalar1 = 8;
            ValidateTestCase(matrix1, scalar1, new double[,] { { -16, 8 }, { 56, 72 } });

            // Test case 2
            double[,] matrix2 = { { 14, -21, 4 }, { 3, 2, 9 }, { -8, 6, 0 } };
            double scalar2 = 3;
            ValidateTestCase(matrix2, scalar2, new double[,] { { 42, -63, 12 }, { 9, 6, 27 }, { -24, 18, 0 } });

            // Test case 3
            double[,] matrix3 = { { 14, -21, 4, 7 }, { 0, 9, 3, -5 } };
            double scalar3 = 1;
            ValidateTestCase(matrix3, scalar3, matrix3); // Scalar is 1, so result should be the same as the original matrix

            // Test case 4
            double[,] matrix4 = { { 1 } };
            double scalar4 = 1;
            ValidateTestCase(matrix4, scalar4, matrix4); // Scalar is 1, so result should be the same as the original matrix
        }

        /// <summary>
        /// Validates a test case for matrix scalar multiplication.
        /// </summary>
        /// <param name="matrix">The input matrix.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <param name="expected">The expected result.</param>
        private static void ValidateTestCase(double[,] matrix, double scalar, double[,] expected)
        {
            Console.WriteLine("Matrix:");
            PrintMatrix(matrix);
            Console.WriteLine($"Scalar: {scalar}");

            double[,] result = MatrixMath.MultiplyScalar(matrix, scalar);

            Console.WriteLine("Result:");
            PrintMatrix(result);

            bool isEqual = CompareMatrices(result, expected);
            Console.WriteLine($"Test {(isEqual ? "Passed!" : "Failed!")}");
            Console.WriteLine();
        }

        /// <summary>
        /// Prints a matrix to the console.
        /// </summary>
        /// <param name="matrix">The matrix to print.</param>
        private static void PrintMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Compares two matrices for equality.
        /// </summary>
        /// <param name="matrix1">The first matrix.</param>
        /// <param name="matrix2">The second matrix.</param>
        /// <returns>True if the matrices are equal, false otherwise.</returns>
        private static bool CompareMatrices(double[,] matrix1, double[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);

            if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
                return false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                        return false;
                }
            }
            return true;
        }
    }
}
