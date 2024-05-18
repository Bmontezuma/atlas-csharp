﻿using System;

public class VectorMath
{
    /// <summary>
    /// Calculates the magnitude of a 2D or 3D vector.
    /// </summary>
    /// <param name="vector">The vector array representing the components.</param>
    /// <returns>The magnitude of the vector rounded to the nearest hundredth, or -1 if not a valid 2D or 3D vector.</returns>
    public static double Magnitude(double[] vector)
    {
        // Check if the vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1; // Not a 2D or 3D vector
        }
        
        // Calculate magnitude using Euclidean norm
        double sumOfSquares = 0;
        foreach (var component in vector)
        {
            sumOfSquares += component * component;
        }
        double magnitude = Math.Sqrt(sumOfSquares);
        
        // Round magnitude to the nearest hundredth
        magnitude = Math.Round(magnitude, 2);
        
        return magnitude;
    }
}
