using System;

namespace Magnitude
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCase(new double[] { 3, -7 }, 7.62);
            TestCase(new double[] { -9, 1, -4 }, 9.9);
            TestCase(new double[] { 0, 0 }, 0);
            TestCase(new double[] { 1, 2, 3, 4 }, -1);
            TestCase(new double[] { 6 }, -1);
            TestCase(new double[] { }, -1);
        }

        static void TestCase(double[] vector, double expected)
        {
            double magnitude = VectorMath.Magnitude(vector);
            Console.WriteLine($"[{string.Join(", ", vector)}]");
            Console.WriteLine($"[Expected] {expected}");
            Console.WriteLine($"[Got] {magnitude}");
            Console.WriteLine();
        }
    }
}