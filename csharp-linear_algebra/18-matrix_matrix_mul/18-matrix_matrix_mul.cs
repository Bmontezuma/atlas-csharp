using System;

public class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians.
    /// </summary>
    /// <param name="matrix">The input square matrix.</param>
    /// <param name="angle">The rotation angle in radians.</param>
    /// <returns>The rotated matrix.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Validate the matrix dimensions (must be square)
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols)
        {
            // Return a matrix containing -1 for invalid size
            return new double[,] { { -1 } };
        }

        // Calculate the sine and cosine of the rotation angle
        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);

        // Initialize the rotated matrix
        double[,] rotatedMatrix = new double[rows, cols];

        // Apply rotation to each element in the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Apply rotation formula
                double x = matrix[i, j];
                double rotatedX = x * cosAngle - matrix[i, j + 1] * sinAngle;
                double rotatedY = x * sinAngle + matrix[i, j + 1] * cosAngle;

                // Round to the nearest hundredth
                rotatedMatrix[i, j] = Math.Round(rotatedX, 2);
                rotatedMatrix[i, j + 1] = Math.Round(rotatedY, 2);
            }
        }

        return rotatedMatrix;
    }
}
