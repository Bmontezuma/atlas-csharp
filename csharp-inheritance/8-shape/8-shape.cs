using System;

/// <summary>
/// Represents a geometric shape.
/// </summary>
public class Shape_8
{
    /// <summary>
    /// Calculates the area of the shape.
    /// </summary>
    /// <returns>The area of the shape.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Represents a rectangle shape.
/// </summary>
public class Rectangle_8 : Shape_8
{
    private int width;
    private int height;

    /// <summary>
    /// Width of the rectangle.
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    /// <summary>
    /// Height of the rectangle.
    /// </summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    /// <summary>
    /// Constructs a rectangle with default width and height of 0.
    /// </summary>
    public Rectangle_8()
    {
        // Default constructor
    }

    /// <summary>
    /// Constructs a rectangle with specified width and height.
    /// </summary>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    public Rectangle_8(int width, int height)
    {
        Width = width;
        Height = height;
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle.</returns>
    public override int Area()
    {
        return Width * Height;
    }

    /// <summary>
    /// Returns a string representation of the rectangle.
    /// </summary>
    /// <returns>A string representing the rectangle.</returns>
    public override string ToString()
    {
        return $"[Rectangle] {Width} / {Height}";
    }
}

public class Square : Rectangle_8
{
    private int size;

    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            size = value;
            Width = value;
            Height = value;
        }
    }

    public override string ToString()
    {
        return $"[Square] {Size} / {Size}";
    }
}
