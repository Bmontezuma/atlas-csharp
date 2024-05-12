using System;

/// <summary>
/// Base class representing a generic entity.
/// </summary>
abstract class Base
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
/// Interface for interactive objects.
/// </summary>
interface IInteractive
{
    /// <summary>
    /// Interact with the object.
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface for breakable objects.
/// </summary>
interface IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Break the object.
    /// </summary>
    void Break();
}

/// <summary>
/// Interface for collectable objects.
/// </summary>
interface ICollectable
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
/// Represents a door object.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Door"/> class with a specified name.
    /// </summary>
    /// <param name="name">The name of the door. Defaults to "Door".</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Performs the interaction with the door.
    /// </summary>
    public void Interact()
    {
        System.Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}
