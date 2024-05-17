using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            // 2D vector: Calculate magnitude using Pythagorean theorem
            double x = vector[0];
            double y = vector[1];
            double magnitude = Math.Sqrt(x * x + y * y);
            return Math.Round(magnitude, 2);
        }
        else if (vector.Length == 3)
        {
            // 3D vector: Calculate magnitude using Euclidean norm
            double x = vector[0];
            double y = vector[1];
            double z = vector[2];
            double magnitude = Math.Sqrt(x * x + y * y + z * z);
            return Math.Round(magnitude, 2);
        }
        else
        {
            // Invalid vector dimension
            return -1;
        }
    }
}
