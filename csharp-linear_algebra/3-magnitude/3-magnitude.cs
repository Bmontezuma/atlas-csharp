﻿using System;

/// <summary>
/// Provides mathematical methods for vector calculations.
/// </summary>
public static class VectorMath
{
    /// <summary>
    /// Calculates and returns the magnitude of a given vector.
    /// </summary>
    /// <param name="vector">The vector to calculate the magnitude for. Can be 2D or 3D.</param>
    /// <returns>The magnitude of the vector rounded to the nearest hundredth, or -1 if the vector is not 2D or 3D.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2 || vector.Length == 3)
        {
            double sumOfSquares = 0;
            foreach (double component in vector)
            {
                sumOfSquares += component * component;
            }
            double magnitude = Math.Sqrt(sumOfSquares);
            return Math.Round(magnitude, 2);
        }
        return -1;
    }
}
