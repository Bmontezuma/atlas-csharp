using System;

namespace VectorMathLibrary
{
    /// <summary>
    /// A class for performing vector operations.
    /// </summary>
    public class VectorMath
    {
        /// <summary>
        /// Calculates the dot product of two vectors.
        /// </summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>The dot product of the two vectors.</returns>
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            if (vector1 == null || vector2 == null)
                throw new ArgumentNullException("Vectors cannot be null.");

            // Check if vectors have the same dimensions
            if (vector1.Length != vector2.Length)
                return -1;

            // Calculate dot product
            double dotProduct = 0;
            for (int i = 0; i < vector1.Length; i++)
            {
                dotProduct += vector1[i] * vector2[i];
            }

            return Math.Round(dotProduct, 2); // Round to the nearest hundredth
        }
    }
}
