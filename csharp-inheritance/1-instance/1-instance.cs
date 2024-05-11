using System;

public class Obj
{
    /// <summary>
    /// Checks if the object is an instance of, or inherits from, Array.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is an instance of Array or inherits from Array, otherwise False.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
