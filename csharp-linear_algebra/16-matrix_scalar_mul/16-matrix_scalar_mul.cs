using System;

/// <summary>
/// Class for performing matrix operations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">The first matrix to multiply.</param>
    /// <param name="matrix2">The second matrix to multiply.</param>
    /// <returns>The resulting matrix after multiplication.</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Check if matrices can be multiplied
        if (cols1 != rows2)
        {
            Console.WriteLine("The matrices cannot be multiplied.");
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows1, cols2];

        // Perform matrix multiplication
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}
