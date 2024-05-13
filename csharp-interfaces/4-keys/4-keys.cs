using System;

/// <summary>
/// Base class representing a generic entity.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the entity.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Override of the ToString() method to provide a string representation of the entity.
    /// </summary>
    /// <returns>A string representation of the entity.</returns>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType()}";
    }
}

/// <summary>
/// Interface for collectable objects.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets or sets whether the object is collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect the object.
    /// </summary>
    void Collect();
}

/// <summary>
/// Represents a key object.
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Gets or sets whether the key is collected.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Key"/> class with a specified name and collected status.
    /// </summary>
    /// <param name="name">The name of the key. Defaults to "Key".</param>
    /// <param name="isCollected">Specifies whether the key is collected. Defaults to false.</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collects the key.
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            Console.WriteLine($"You pick up the {name}.");
            isCollected = true;
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}
