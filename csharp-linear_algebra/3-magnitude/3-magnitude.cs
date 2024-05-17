using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            // Calculate 2D vector magnitude: sqrt(x^2 + y^2)
            double x = vector[0];
            double y = vector[1];
            double magnitude = Math.Sqrt(x * x + y * y);
            return Math.Round(magnitude, 2);
        }
        else if (vector.Length == 3)
        {
            // Calculate 3D vector magnitude: sqrt(x^2 + y^2 + z^2)
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

    // Example usage:
    public static void Main()
    {
        double[] vector2D = { 3.0, 4.0 }; // Example 2D vector
        double[] vector3D = { 1.0, 2.0, 3.0 }; // Example 3D vector

        Console.WriteLine($"Magnitude of 2D vector: {Magnitude(vector2D)}");
        Console.WriteLine($"Magnitude of 3D vector: {Magnitude(vector3D)}");
    }
}
