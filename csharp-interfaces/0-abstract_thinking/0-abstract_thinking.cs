/// <summary>
/// An abstract base class.
/// </summary>
using System;

public abstract class Base
{
    /// <summary>
    /// The name property.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Overrides the ToString() method to return the name and type of the object.
    /// </summary>
    /// <returns>The name and type of the object.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}
