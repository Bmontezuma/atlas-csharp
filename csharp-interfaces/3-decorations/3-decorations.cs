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
/// Represents a decoration entity.
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the decoration.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Gets or sets whether the decoration is a quest item.
    /// </summary>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Decoration"/> class with the specified name, durability, and quest item status.
    /// </summary>
    /// <param name="name">The name of the decoration. Defaults to "Decoration".</param>
    /// <param name="durability">The durability of the decoration. Defaults to 1.</param>
    /// <param name="isQuestItem">Indicates whether the decoration is a quest item. Defaults to false.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        this.name = name;
        this.durability = durability > 0 ? durability : throw new ArgumentException("Durability must be greater than 0");
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Implements the Interact method for the Decoration class.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken.");
            return;
        }

        if (isQuestItem)
        {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Implements the Break method for the Decoration class.
    /// </summary>
    public void Break()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {this.name} is already broken.");
            return;
        }

        if (durability > 0)
        {
            durability--;
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }

        if (durability == 0)
        {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        }
    }
}
