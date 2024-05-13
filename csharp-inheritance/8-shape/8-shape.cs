using System;

/// <summary>
/// Represents a square shape.
/// </summary>
public class Square : Rectangle
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
            Width = value;
            Height = value;
        }
    }
}
