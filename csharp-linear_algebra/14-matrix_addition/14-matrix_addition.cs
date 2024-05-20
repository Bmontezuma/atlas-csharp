using System;

namespace MatrixMathLibrary
{
    /// <summary>
    /// A class for performing matrix operations.
    /// </summary>
    public class MatrixMath
    {
        /// <summary>
        /// Adds two matrices and returns the resulting matrix.
        /// </summary>
        /// <param name="matrix1">The first matrix.</param>
        /// <param name="matrix2">The second matrix.</param>
        /// <returns>The resulting matrix after addition.</returns>
        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1 == null || matrix2 == null)
                throw new ArgumentNullException("Matrices cannot be null.");

            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            // Check if matrices are of the same size
            if (rows1 != rows2 || cols1 != cols2)
                return new double[,] { { -1 } };

            // Perform matrix addition
            double[,] result = new double[rows1, cols1];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
    }
}
