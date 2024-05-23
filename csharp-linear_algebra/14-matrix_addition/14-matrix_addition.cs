using System;

public class MatrixMath
{
    /// <summary>
    /// Adds two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">The first matrix.</param>
    /// <param name="matrix2">The second matrix.</param>
    /// <returns>The resulting matrix or a matrix containing -1 if any conditions are not met.</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Check if both matrices are either 2D or 3D
        bool is2DMatrix1 = rows1 == 2 && cols1 == 2;
        bool is2DMatrix2 = rows2 == 2 && cols2 == 2;
        bool is3DMatrix1 = rows1 == 3 && cols1 == 3;
        bool is3DMatrix2 = rows2 == 3 && cols2 == 3;

        if (!((is2DMatrix1 && is2DMatrix2) || (is3DMatrix1 && is3DMatrix2)))
        {
            Console.WriteLine("Both matrices must be either 2D or 3D.");
            return new double[,] { { -1 } };
        }

        // Check if both matrices have the same size
        if (rows1 != rows2 || cols1 != cols2)
        {
            Console.WriteLine("Both matrices must have the same size.");
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows1, cols1];

        // Perform matrix addition
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
