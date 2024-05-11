using System;

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
