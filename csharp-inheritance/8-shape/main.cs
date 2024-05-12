// 8-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Square aSquare = new Square();

        aSquare.Size = 10;

        if (typeof(Square).IsSubclassOf(typeof(Shape)))
            Console.WriteLine("Square is a subclass of Shape");
        else
            Console.WriteLine("Square is NOT a subclass of Shape");

        Console.WriteLine("Size: {0}", aSquare.Size);
    }
}
