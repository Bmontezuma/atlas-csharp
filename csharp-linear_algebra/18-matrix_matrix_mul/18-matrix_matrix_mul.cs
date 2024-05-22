using System;

namespace MatrixMath
{
    /// <summary>
    /// Provides methods for matrix operations.
    /// </summary>
    public class MatrixMath
    {
        /// <summary>
        /// Multiplies two matrices and returns the resulting matrix.
        /// </summary>
        /// <param name="matrix1">The first matrix.</param>
        /// <param name="matrix2">The second matrix.</param>
        /// <returns>The resulting matrix or a matrix containing -1 if multiplication is not possible.</returns>
        public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
            int rowsA = matrix1.GetLength(0);
            int colsA = matrix1.GetLength(1);
            int rowsB = matrix2.GetLength(0);
            int colsB = matrix2.GetLength(1);

            if (colsA != rowsB)
            {
                return new double[,] { { -1 } };
            }

            double[,] result = new double[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }
    }
}
