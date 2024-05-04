using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
        {
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < length; i++)
        {
            // Print spaces before the '\' character
            Console.Write(new string(' ', i));

            // Print the '\' character
            Console.WriteLine("\\");
        }
    }
}

class ExecutePrintDiagonal
{
    static void Main(string[] args)
    {
        Line.PrintDiagonal(3);
        Line.PrintDiagonal(0);
        Line.PrintDiagonal(12);
        Line.PrintDiagonal(-98);
    }
}
