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
/// Represents a door entity.
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor for the Door class.
    /// </summary>
    /// <param name="name">The name of the door.</param>
    public Door(string name)
    {
        this.name = string.IsNullOrEmpty(name) ? "Door" : name;
    }

    /// <summary>
    /// Implementation of the Interact method for the Door class.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}

/// <summary>
/// Main program class.
/// </summary>
class Program
{
    /// <summary>
    /// Main method.
    /// </summary>
    static void Main(string[] args)
    {
        Door frontDoor = new Door("Front Door");

        Console.WriteLine(frontDoor.ToString());

        frontDoor.Interact();
    }
}
