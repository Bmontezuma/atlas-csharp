using System;

/// <summary>
/// An abstract class representing a base entity.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the entity.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Returns a string representation of the entity.
    /// </summary>
    /// <returns>A string in the format '<see cref="name"/> is a <see cref="T:Base"/>'.</returns>
    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}

/// <summary>
/// An interface for interactive objects.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Method for interacting with the object.
    /// </summary>
    void Interact();
}

/// <summary>
/// Represents a door object.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor for the Door class.
    /// </summary>
    /// <param name="name">The name of the door.</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interaction method for the door.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
