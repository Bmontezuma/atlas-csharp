using System;

namespace MatrixMathLibrary
{
    public static class MatrixMath
    {
        public static double[,] Inverse2D(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Check if the matrix is a 2D matrix
            if (rows != 2 || cols != 2)
            {
                return new double[,] { { -1 } };
            }

            // Calculate determinant
            double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

            // Check if the matrix is invertible
            if (Math.Abs(determinant) < double.Epsilon)
            {
                return new double[,] { { -1 } };
            }

            // Calculate inverse
            double[,] inverse = new double[2, 2];
            inverse[0, 0] = matrix[1, 1] / determinant;
            inverse[0, 1] = -matrix[0, 1] / determinant;
            inverse[1, 0] = -matrix[1, 0] / determinant;
            inverse[1, 1] = matrix[0, 0] / determinant;

            return inverse;
        }
    }
}
