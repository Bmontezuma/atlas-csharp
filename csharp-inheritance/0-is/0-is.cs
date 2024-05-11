using System;

public class Obj
{
    /// <summary>
    /// Checks if the object is of type int.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is an int, otherwise False.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
