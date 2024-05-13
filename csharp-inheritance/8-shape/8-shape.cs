using System;

/// <summary>
/// Represents a square shape.
/// </summary>
public class Square : Shape
{
    private int size;

    /// <summary>
    /// Size of the square.
    /// </summary>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            size = value;
        }
    }

    /// <summary>
    /// Calculates the area of the square.
    /// </summary>
    /// <returns>The area of the square.</returns>
    public override int Area()
    {
        return size * size;
    }
}
