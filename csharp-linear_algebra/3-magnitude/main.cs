using System;

namespace VectorMathLibrary
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Test cases
            double[] vector1 = { 3, -7 };
            double[] vector2 = { -9, 1, -4 };
            double[] vector3 = { 0, 0 };
            double[] vector4 = { 1, 2, 3, 4 };
            double[] vector5 = { 6 };
            double[] vector6 = { };

            // Create VectorMath objects
            VectorMath vec1 = new VectorMath(vector1);
            VectorMath vec2 = new VectorMath(vector2);
            VectorMath vec3 = new VectorMath(vector3);
            VectorMath vec4 = new VectorMath(vector4);
            VectorMath vec5 = new VectorMath(vector5);
            VectorMath vec6 = new VectorMath(vector6);

            // Test getter and setter methods
            Console.WriteLine($"Component at index 1 of vector {string.Join(", ", vector1)}: {vec1[1]}");
            vec1[1] = 10; // Change component at index 1
            Console.WriteLine($"New component at index 1 of vector {string.Join(", ", vector1)}: {vec1[1]}");

            // Test the Magnitude method
            Console.WriteLine($"Magnitude of vector {string.Join(", ", vector1)}: {vec1.Magnitude()}");
            Console.WriteLine($"Magnitude of vector {string.Join(", ", vector2)}: {vec2.Magnitude()}");
            Console.WriteLine($"Magnitude of vector {string.Join(", ", vector3)}: {vec3.Magnitude()}");
            Console.WriteLine($"Magnitude of vector {string.Join(", ", vector4)}: {vec4.Magnitude()}");
            Console.WriteLine($"Magnitude of vector {string.Join(", ", vector5)}: {vec5.Magnitude()}");
            Console.WriteLine($"Magnitude of vector {string.Join(", ", vector6)}: {vec6.Magnitude()}");
        }
    }
}
