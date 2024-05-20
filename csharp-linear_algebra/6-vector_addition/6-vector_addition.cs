using System;

/// <summary>
/// Provides methods for vector operations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Adds two vectors and returns the resulting vector.
    /// </summary>
    /// <param name="vector1">The first vector.</param>
    /// <param name="vector2">The second vector.</param>
    /// <returns>The resulting vector as an array of doubles.</returns>
    /// <remarks>
    /// Vectors must be of the same dimension (2D or 3D). If not, returns a vector with a single element -1.
    /// </remarks>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
        {
            return new double[] { -1 }; // Return a vector with a single element -1 if vectors are not of the same size
        }

        int n = vector1.Length;
        double[] result = new double[n];

        for (int i = 0; i < n; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }

        return result;
    }
}
