using System;

namespace MatrixMathLibrary
{
    /// <summary>
    /// Provides methods for matrix operations.
    /// </summary>
    public class MatrixMath
    {
        /// <summary>
        /// Multiplies a matrix by a scalar.
        /// </summary>
        /// <param name="matrix">The matrix to multiply.</param>
        /// <param name="scalar">The scalar value to multiply by.</param>
        /// <returns>The resulting matrix after scalar multiplication.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the input matrix is null.</exception>
        public static double[,] MultiplyScalar(double[,] matrix, double scalar)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix), "Matrix cannot be null.");

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            double[,] result = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }

            return result;
        }
    }
}
