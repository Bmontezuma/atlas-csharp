namespace LinearAlgebra
{
    public static class VectorMath
    {
        /// <summary>
        /// Calculates the dot product of two 2D or 3D vectors.
        /// </summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>
        /// The dot product of the two vectors if they are both 2D or both 3D.
        /// Returns -1 if the vectors are not the same size or if they are not 2D or 3D vectors.
        /// </returns>
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            if (vector1.Length != vector2.Length || (vector1.Length != 2 && vector1.Length != 3))
            {
                return -1;
            }

            double dotProduct = 0;
            for (int i = 0; i < vector1.Length; i++)
            {
                dotProduct += vector1[i] * vector2[i];
            }
            return dotProduct;
        }
    }
}
