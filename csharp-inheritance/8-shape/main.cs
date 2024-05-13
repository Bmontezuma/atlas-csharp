using System;

class Program_0
{
    static void Main_0(string[] args)
    {
        Square aSquare = new Square();

        aSquare.Size = 12;

        if (typeof(Square).IsSubclassOf(typeof(Shape)))
            Console.WriteLine("Square is a subclass of Shape");
        else
            Console.WriteLine("Square is NOT a subclass of Shape");

        Console.WriteLine("Size: {0}", aSquare.Size);
    }
}
