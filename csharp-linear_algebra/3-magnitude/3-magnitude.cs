﻿using System;

/// <summary>
/// A static class containing methods for performing vector math operations.
/// </summary>
public static class VectorMath
{
    /// <summary>
    /// Calculates the magnitude (length) of a double array (vector) representing a 2D or 3D vector.
    /// </summary>
    /// <param name="vector">The double array representing a 2D or 3D vector.</param>
    /// <returns>
    /// The magnitude (length) of the input vector, rounded to the nearest hundredth, 
    /// or -1 if the vector is not a 2D or 3D vector.
    /// </returns>
    public static double Magnitude(double[] vector)
    {
        // Check if the length of the input vector is within the valid range (2-3).
        if (vector.Length > 3 || vector.Length < 2)
            return -1;
        
        // Calculate the sum of the squares of the vector's elements.
        double sum = 0;
        foreach (double i in vector)
            sum += i * i;
        
        // Return the magnitude (length) of the input vector.
        return Math.Round(Math.Sqrt(sum), 2);
    }
}
