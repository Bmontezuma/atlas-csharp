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
/// Interface for interactive objects.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interact with the object.
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface for breakable objects.
/// </summary>
public interface IBreakable
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
/// Represents a decoration object.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
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
    /// Initializes a new instance of the <see cref="Decoration"/> class with a specified name, durability, and quest item status.
    /// </summary>
    /// <param name="name">The name of the decoration. Defaults to "Decoration".</param>
    /// <param name="durability">The durability of the decoration. Defaults to 1.</param>
    /// <param name="isQuestItem">Specifies whether the decoration is a quest item. Defaults to false.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Performs the interaction with the decoration.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Breaks the decoration.
    /// </summary>
    public void Break()
    {
        if (durability > 0)
        {
            durability--;

            if (durability > 0)
            {
                Console.WriteLine($"You hit the {name}. It cracks.");
            }
            else
            {
                Console.WriteLine($"You smash the {name}. What a mess.");
            }
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
