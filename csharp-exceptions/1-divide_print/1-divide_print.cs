using System;

public static class Int
{
    public static void Divide(int a, int b)
    {
        try
        {
            // Check if the divisor is zero
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }

            int result = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            // Print the result in the finally block
            if (a != 0 && b != 0)
            {
                Console.WriteLine("The result of the division is: " + (a / b));
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Int.Divide(10, 2);
        Int.Divide(10, 0);
        Int.Divide(0, 5);
    }
}
