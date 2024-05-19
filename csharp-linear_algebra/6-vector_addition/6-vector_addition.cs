using System;

/// <summary>
/// Provides methods for vector calculations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Adds two vectors and returns the resulting vector.
    /// </summary>
    /// <param name="vector1">The first vector.</param>
    /// <param name="vector2">The second vector.</param>
    /// <returns>The resulting vector if addition is successful, or a vector containing -1 if vectors are not 2D or 3D or are of different sizes.</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // Check if vectors are 2D or 3D
        if (vector1.Length != 2 && vector1.Length != 3)
            return new double[] { -1 };
        if (vector2.Length != 2 && vector2.Length != 3)
            return new double[] { -1 };
        
        // Check if vectors are of the same size
        if (vector1.Length != vector2.Length)
            return new double[] { -1 };
        
        // Perform vector addition
        double[] result = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }
        
        // Round results to the nearest hundredth if needed
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = Math.Round(result[i], 2);
        }
        
        return result;
    }
}
