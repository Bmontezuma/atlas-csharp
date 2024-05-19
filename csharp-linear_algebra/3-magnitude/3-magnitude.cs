﻿using System;

namespace Magnitude
{
    /// <summary>
    /// A static class containing methods for vector mathematics.
    /// </summary>
    public static class VectorMath
    {
        /// <summary>
        /// Calculates the magnitude of a given vector.
        /// </summary>
        /// <param name="vector">The vector to calculate the magnitude of.</param>
        /// <returns>The magnitude of the vector, rounded to the nearest hundredth.</returns>
        /// <remarks>
        /// The vector can be 2D or 3D. If the vector is not a 2D or 3D vector, -1 is returned.
        /// </remarks>
        public static double Magnitude(double[] vector)
        {
            if (vector.Length == 2 || vector.Length == 3)
            {
                return Math.Round(Math.Sqrt(vector.Select(v => v * v).Sum()), 2);
            }
            else
            {
                return -1;
            }
        }
    }
}