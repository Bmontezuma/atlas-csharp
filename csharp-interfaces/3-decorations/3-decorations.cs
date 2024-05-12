using System;

/// <summary>
/// Represents a base class.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name of the object.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Prints the name and type of the object.
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// Represents an interactive interface.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interacts with an object.
    /// </summary>
    void Interact();
}

/// <summary>
/// Represents a breakable interface.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Durability of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Breaks the object.
    /// </summary>
    void Break();
}

/// <summary>
/// Represents a decoration.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Durability of the decoration.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Indicates if the decoration is a quest item.
    /// </summary>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// Constructor for creating a decoration.
    /// </summary>
    /// <param name="name">Name of the decoration (default: "Decoration").</param>
    /// <param name="durability">Durability of the decoration (default: 1).</param>
    /// <param name="isQuestItem">Indicates if the decoration is a quest item (default: false).</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        this.name = name;
        this.durability = durability;

        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }

        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interacts with the decoration.
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
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Test case: no parameters given
        Decoration noParams = new Decoration();
        Console.WriteLine(noParams.ToString());
        noParams.Interact();
        noParams.Break();
        noParams.Break();
        noParams.Interact();
        Console.WriteLine($"isQuestItem: {noParams.isQuestItem}");

        // Test case: no name given / 10 / true
        Decoration noName = new Decoration(durability: 10, isQuestItem: true);
        Console.WriteLine(noName.ToString());
        noName.Interact();
        noName.Break();
        noName.Break();
        noName.Interact();
        Console.WriteLine($"isQuestItem: {noName.isQuestItem}");

        // Test case: "Expensive Figurine" / no value given / true / change item values
        Decoration expensiveFigurine = new Decoration("Expensive Figurine", isQuestItem: true);
        Console.WriteLine(expensiveFigurine.ToString());
        expensiveFigurine.Interact();
        expensiveFigurine.Break();
        expensiveFigurine.Break();
        expensiveFigurine.Interact();
        Console.WriteLine($"isQuestItem: {expensiveFigurine.isQuestItem}");
    }
}
