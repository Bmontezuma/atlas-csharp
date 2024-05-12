using System;

/// <summary>
/// Represents a base entity with a name.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Gets or sets the name of the entity.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Returns a string representation of the entity.
    /// </summary>
    /// <returns>A string representation of the entity.</returns>
    public override string ToString()
    {
        return $"{Name} is a {GetType().Name}";
    }
}
