using System;

class Program
{
    static void Main(string[] args)
    {
        Square_8 aSquare = new Square_8();

        aSquare.Size = 12;

        if (typeof(Square_8).IsSubclassOf(typeof(Shape_8)))
            Console.WriteLine("Square is a subclass of Shape");
        else
            Console.WriteLine("Square is NOT a subclass of Shape");

        Console.WriteLine("Size: {0}", aSquare.Size);
    }
}
