using System;

/// <summary>
/// Class for performing matrix operations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar.
    /// </summary>
    /// <param name="matrix">The matrix to multiply.</param>
    /// <param name="scalar">The scalar to multiply by.</param>
    /// <returns>The resulting matrix after scalar multiplication.</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is 2D or 3D
        if (rows != 2 && rows != 3 && cols != 2 && cols != 3)
        {
            Console.WriteLine("The matrix must be either 2D or 3D.");
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, cols];

        // Perform scalar multiplication
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
