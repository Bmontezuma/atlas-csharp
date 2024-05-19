﻿using System;

/// <summary>
/// A class for vector math operations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the magnitude (length) of a given vector.
    /// </summary>
    /// <param name="vector">The vector array (2D or 3D).</param>
    /// <returns>The magnitude rounded to the nearest hundredth, or -1 if the vector is not 2D or 3D.</returns>
    public static double Magnitude(double[] vector)
    {
        // Check if the vector is 2D or 3D
        if (vector.Length == 2 || vector.Length == 3)
        {
            // Calculate the magnitude
            double sumOfSquares = 0;
            foreach (double component in vector)
            {
                sumOfSquares += component * component;
            }
            double magnitude = Math.Sqrt(sumOfSquares);

            // Round to the nearest hundredth
            magnitude = Math.Round(magnitude, 2);

            return magnitude;
        }
        else
        {
            // Return -1 for vectors that are not 2D or 3D
            return -1;
        }
    }
}
