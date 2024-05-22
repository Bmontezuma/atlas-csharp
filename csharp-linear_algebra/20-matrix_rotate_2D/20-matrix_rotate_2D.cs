using System;

namespace MatrixMath
{
    /// <summary>
    /// Contains methods for performing matrix math operations.
    /// </summary>
    public static class MatrixMath
    {
        /// <summary>
        /// Multiplies two matrices and returns the resulting matrix.
        /// </summary>
        /// <param name="matrix1">First matrix to multiply.</param>
        /// <param name="matrix2">Second matrix to multiply.</param>
        /// <returns>The resulting matrix or a matrix containing -1 if they cannot be multiplied.</returns>
        public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                return new double[,] { { -1 } };
            }

            double[,] result = new double[rows1, cols2];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = Math.Round(result[i, j], 2);
                }
            }

            return result;
        }
    }
}
