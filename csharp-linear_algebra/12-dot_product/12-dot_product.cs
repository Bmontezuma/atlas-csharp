using System;

namespace Atlas.CSharp.LinearAlgebra
{
    public static class VectorMath
    {
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            if (vector1 == null || vector2 == null || vector1.Length != vector2.Length)
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