using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Test cases
        double[] vector1 = new double[] { 0, 6 };
        double[] result1 = VectorMath.Multiply(vector1, 2);
        Console.WriteLine("Result 1: (" + string.Join(", ", result1) + ")"); // Expected: (0, 12)

        double[] vector2 = new double[] { -3, 7 };
        double[] result2 = VectorMath.Multiply(vector2, -1);
        Console.WriteLine("Result 2: (" + string.Join(", ", result2) + ")"); // Expected: (3, -7)

        double[] vector3 = new double[] { -2, 1, 8 };
        double[] result3 = VectorMath.Multiply(vector3, 0.5);
        Console.WriteLine("Result 3: (" + string.Join(", ", result3) + ")"); // Expected: (-1, 0.5, 4)

        double[] vector4 = new double[] { 1, -3, 0 };
        double[] result4 = VectorMath.Multiply(vector4, 3);
        Console.WriteLine("Result 4: (" + string.Join(", ", result4) + ")"); // Expected: (3, -9, 0)

        double[] vector5 = new double[] { 2 };
        double[] result5 = VectorMath.Multiply(vector5, 3);
        Console.WriteLine("Result 5: (" + string.Join(", ", result5) + ")"); // Expected: (-1)

        double[] vector6 = new double[] { 1, 7, 2, -2 };
        double[] result6 = VectorMath.Multiply(vector6, 3);
        Console.WriteLine("Result 6: (" + string.Join(", ", result6) + ")"); // Expected: (-1)

        double[] vector7 = new double[] { };
        double[] result7 = VectorMath.Multiply(vector7, 3);
        Console.WriteLine("Result 7: (" + string.Join(", ", result7) + ")"); // Expected: (-1)
    }
}
