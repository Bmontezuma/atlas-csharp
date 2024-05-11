using System;
using System.Collections.Generic;

/// <summary>
/// Represents a geometric shape.
/// </summary>
class Rectangle
{
    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangle"/> class with the specified width and height.
    /// </summary>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle.</returns>
    public virtual int Area()
    {
        return Width * Height;
    }
}

/// <summary>
/// Represents a square, which is a special type of rectangle with equal width and height.
/// </summary>
class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Gets or sets the size of the square.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the specified size is negative.</exception>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                size = value;
                Width = size;
                Height = size;
            }
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Square"/> class with the specified size.
    /// </summary>
    /// <param name="size">The size of the square.</param>
    public Square(int size) : base(size, size)
    {
        Size = size;
    }
}

/// <summary>
/// Represents the entry point of the program.
/// </summary>
class Program
{
    /// <summary>
    /// The entry point of the program.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    static void Main(string[] args)
    {
        Square aSquare = new Square(10);

        if (typeof(Square).IsSubclassOf(typeof(Rectangle)))
        {
            Console.WriteLine("Square is a subclass of Rectangle");
        }
        else
        {
            Console.WriteLine("Square is NOT a subclass of Rectangle");
        }

        Console.WriteLine("Size: {0}", aSquare.Size);
    }
}
