using System;

namespace VectorMathLibrary
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Test cases
            double[] vector0 = { 3, -7 };
            double[] vector1 = { -9, 1, -4 };
            double[] vector2 = { 0, 0 };
            double[] vector3 = { 1, 2, 3, 4 };
            double[] vector4 = { 6 };
            double[] vector5 = { };

            // Create VectorMath objects
            VectorMath vec0 = new VectorMath(vector0);
            VectorMath vec1 = new VectorMath(vector1);
            VectorMath vec2 = new VectorMath(vector2);
            VectorMath vec3 = new VectorMath(vector3);
            VectorMath vec4 = new VectorMath(vector4);
            VectorMath vec5 = new VectorMath(vector5);

            // Test the Magnitude method
            Console.WriteLine($"Expected Magnitude of vector {string.Join(", ", vector0)}: 7.62");
            Console.WriteLine($"Got Magnitude: {vec0.Magnitude()}");

            Console.WriteLine($"Expected Magnitude of vector {string.Join(", ", vector1)}: 9.9");
            Console.WriteLine($"Got Magnitude: {vec1.Magnitude()}");

            Console.WriteLine($"Expected Magnitude of vector {string.Join(", ", vector2)}: 0");
            Console.WriteLine($"Got Magnitude: {vec2.Magnitude()}");

            Console.WriteLine($"Expected Magnitude of vector {string.Join(", ", vector3)}: -1");
            Console.WriteLine($"Got Magnitude: {vec3.Magnitude()}");

            Console.WriteLine($"Expected Magnitude of vector {string.Join(", ", vector4)}: -1");
            Console.WriteLine($"Got Magnitude: {vec4.Magnitude()}");

            Console.WriteLine($"Expected Magnitude of vector {string.Join(", ", vector5)}: -1");
            Console.WriteLine($"Got Magnitude: {vec5.Magnitude()}");
        }
    }
}
