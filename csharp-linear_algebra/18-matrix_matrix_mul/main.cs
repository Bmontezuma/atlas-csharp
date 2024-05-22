using System;

namespace MatrixMath
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestMatrices(new double[,] { { -1, 2 }, { 4, 6 } }, new double[,] { { -7, 11 }, { 5, 5 } }, new double[,] { { 17, -1 }, { 2, 74 } });
            TestMatrices(new double[,] { { 3, -1, 2 }, { 4, 6, -5 }, { 7, 4, 6 } }, new double[,] { { 2, -2, 0 }, { 8, -8, 1 }, { 9, -5, 4 } }, new double[,] { { 16, -8, 7 }, { 11, -31, -14 }, { 100, -76, 28 } });
            TestMatrices(new double[,] { { -1, 2 }, { 3, 4 } }, new double[,] { { 1, 2, 3 }, { 4, 5, 6 } }, new double[,] { { 7, 8, 9 }, { 19, 26, 33 } });
            TestMatrices(new double[,] { { 1, 2, 3 }, { -4, 5, 6 } }, new double[,] { { -6, 1 }, { -3, 9 }, { 2, 4 } }, new double[,] { { -6, 31 }, { 21, 65 } });
            TestMatrices(new double[,] { { 1, 2, 3, -4 }, { 5, 6, 7, 8 } }, new double[,] { { 7, 11 }, { 3, 4 }, { -5, 5 }, { 1, 4 } }, new double[,] { { -6, 18 }, { 26, 146 } });
            TestMatrices(new double[,] { { 1, 2, 3, -4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, -14, 15, 16 }, { 17, 18, 19, 20 } }, new double[,] { { 3 }, { 7 }, { -2 }, { 5 } }, new double[,] { { -9 }, { 83 }, { 135 }, { -9 }, { 239 } });
            TestMatrices(new double[,] { { 1, 2 }, { -4, 6 } }, new double[,] { { 7, 11 }, { 3, 4 }, { -5, 5 } }, new double[,] { { -1 } });
            TestMatrices(new double[,] { { 1, 2 }, { -4, 6 } }, new double[,] { { 3, 7, 11 }, { 4, 3, 4 }, { 6, -5, 5 } }, new double[,] { { -1 } });
            TestMatrices(new double[,] { { 2 } }, new double[,] { { 4 } }, new double[,] { { 8 } });
        }

        public static void TestMatrices(double[,] matrix1, double[,] matrix2, double[,] expectedResult)
        {
            double[,] result = MatrixMath.Multiply(matrix1, matrix2);
            PrintMatrix(result);

            if (AreMatricesEqual(result, expectedResult))
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }

        public static bool AreMatricesEqual(double[,] matrix1, double[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (rows1 != rows2 || cols1 != cols2)
            {
                return false;
            }

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void PrintMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
