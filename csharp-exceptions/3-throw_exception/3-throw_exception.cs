using System;

public class Except
{
    public static void Throw()
    {
        // Throw a custom exception (you can choose any specific exception type)
        throw new Exception("Custom exception thrown intentionally");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Except.Throw();
        }
        catch (Exception)
        {
            Console.WriteLine("Exception raised");
        }
    }
}
