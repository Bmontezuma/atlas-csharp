using System;

namespace Atlas.CSharp.LinearAlgebra
{
    /// <summary>
    /// Class for performing vector math operations.
    /// </summary>
    public static class VectorMath
    {
        /// <summary>
        /// Calculates the dot product of two vectors.
        /// </summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>The dot product of the two vectors, or -1 if the vectors are not valid.</returns>
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            if (vector1 == null || vector2 == null || vector1.Length != vector2.Length || (vector1.Length != 2 && vector1.Length != 3))
            {
                return -1;
            }

            double sum = 0;
            for (int i = 0; i < vector1.Length; i++)
            {
                sum += vector1[i] * vector2[i];
            }

            return sum;
        }
    }
}