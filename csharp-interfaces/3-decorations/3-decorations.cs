using System;

/// <summary>
/// Represents a decoration object.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the decoration.
    /// </summary>
    public int Durability { get; set; }

    /// <summary>
    /// Gets or sets whether the decoration is a quest item.
    /// </summary>
    public bool IsQuestItem { get; set; }

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
        this.Durability = durability;
        this.IsQuestItem = isQuestItem;
    }

    /// <summary>
    /// Performs the interaction with the decoration.
    /// </summary>
    public void Interact()
    {
        if (this.Durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (this.IsQuestItem)
        {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Breaks the decoration.
    /// </summary>
    public void Break()
    {
        if (this.Durability > 0)
        {
            this.Durability--;

            if (this.Durability > 0)
            {
                Console.WriteLine($"You hit the {this.name}. It cracks.");
            }
            else
            {
                Console.WriteLine($"You smash the {this.name}. What a mess.");
            }
        }
        else
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }
}
