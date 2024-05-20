using System;

namespace MatrixMathLibrary
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            // Test case 1
            double[,] matrix1 = { { -6, 1 }, { -8, 7 } };
            double[,] matrix2 = { { 9, -2 }, { -1, 2 } };
            ValidateTestCase(matrix1, matrix2, new double[,] { { 3, -1 }, { -9, 9 } });

            // Test case 2
            matrix1 = new double[,] { { 2, -9, 7 }, { 8, -6, 2 }, { -2, 5, -3 } };
            matrix2 = new double[,] { { 3, -1, 0 }, { -3, 6, -9 }, { 1, 4, 4 } };
            ValidateTestCase(matrix1, matrix2, new double[,] { { 5, -10, 7 }, { 5, 0, -7 }, { -1, 9, 1 } });

            // Test case 3
            matrix1 = new double[,] { { 2, -9, 7 }, { 8, -6, 2 }, { -2, 5, -3 } };
            matrix2 = new double[,] { { 3, -1, 0 }, { 1, 4, 4 } };
            ValidateTestCase(matrix1, matrix2, new double[,] { { -1 } });

            // Test case 4
            matrix1 = new double[,] { { 2, -9, 7 }, { -2, 5, -3 } };
            matrix2 = new double[,] { { 3, -1, 0 }, { 1, 4, 4 }, { 8, -6, 2 } };
            ValidateTestCase(matrix1, matrix2, new double[,] { { -1 } });

            // Test case 5
            matrix1 = new double[,] { { 2, -9, 7 }, { -2, 5, -3 } };
            matrix2 = new double[,] { { 3, -1, 0 } };
            ValidateTestCase(matrix1, matrix2, new double[,] { { -1 } });

            // Test case 6
            matrix1 = new double[,] { { 2, -9, 7 } };
            matrix2 = new double[,] { { 3, -1, 0 } };
            ValidateTestCase(matrix1, matrix2, new double[,] { { -1 } });

            // Test case 7
            matrix1 = new double[,] { { 2, -9, 7, 2 }, { 8, -6, 2, 7 }, { 1, -2, 5, -3 } };
            matrix2 = new double[,] { { 3, -1, 0 }, { -3, 6, -9 }, { 1, 4, 4 } };
            ValidateTestCase(matrix1, matrix2, new double[,] { { -1 } });
        }

        // Helper method to validate a test case
        private static void ValidateTestCase(double[,] matrix1, double[,] matrix2, double[,] expected)
        {
            double[,] result = MatrixMath.Add(matrix1, matrix2);
            Console.WriteLine("Got:");
            PrintMatrix(result);
            Console.WriteLine("Expected:");
            PrintMatrix(expected);

            bool isEqual = CompareMatrices(result, expected);
            Console.WriteLine($"Test {(isEqual ? "Passed!" : "Failed!")}");
            Console.WriteLine();
        }

        // Helper method to print a matrix
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

        // Helper method to compare two matrices
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
