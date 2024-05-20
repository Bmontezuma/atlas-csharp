using System;

class Program
{
    static void Main()
    {
        // Test cases
        double[] vector1 = { 1, -8 };
        double[] vector2 = { -7, 0 };
        TestVectorAddition(vector1, vector2); // Expected output: (-6, -8)

        double[] vector3 = { 9, 2, -12 };
        double[] vector4 = { 22, -1, 0 };
        TestVectorAddition(vector3, vector4); // Expected output: (31, 1, -12)

        double[] vector5 = { 9, 2, -12 };
        double[] vector6 = { 22, 0 };
        TestVectorAddition(vector5, vector6); // Expected output: (-1)

        double[] vector7 = { 22, 0 };
        double[] vector8 = { 9, 2, -12 };
        TestVectorAddition(vector7, vector8); // Expected output: (-1)

        double[] vector9 = { 9 };
        double[] vector10 = { 22 };
        TestVectorAddition(vector9, vector10); // Expected output: (-1)

        double[] vector11 = { 9, 10, 11, 12 };
        double[] vector12 = { 22, 23, 24, 25 };
        TestVectorAddition(vector11, vector12); // Expected output: (-1)
    }

    static void TestVectorAddition(double[] vector1, double[] vector2)
    {
        Console.WriteLine($"Correct output - case: {{{string.Join(", ", vector1)}}} // {{{string.Join(", ", vector2)}}}");

        // Call VectorMath.Add method
        double[] result = VectorMath.Add(vector1, vector2);

        // Print the result
        Console.WriteLine($"[Got]");
        Console.WriteLine($"({string.Join(", ", result)})");

        // Print expected output
        Console.WriteLine($"[Expected]");
        Console.WriteLine($"({string.Join(", ", result)})");

        Console.WriteLine($"({result.Length} chars long)");
        Console.WriteLine();
    }
}
