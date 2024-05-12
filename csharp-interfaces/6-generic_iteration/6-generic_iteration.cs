using System;
using System.Collections.Generic;
using System.Linq;

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

/// <summary>
/// Represents a key entity.
/// </summary>
class Key : Base, ICollectable
{
    /// <summary>
    /// Gets or sets whether the key is collected.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Key"/> class with the specified name and collection status.
    /// </summary>
    /// <param name="name">The name of the key. Defaults to "Key".</param>
    /// <param name="isCollected">Indicates whether the key is already collected. Defaults to false.</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Implements the Collect method for the Key class.
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            Console.WriteLine($"You pick up the {this.name}.");
            isCollected = true;
        }
        else
        {
            Console.WriteLine($"You have already picked up the {this.name}.");
        }
    }
}

/// <summary>
/// Represents a collection of objects of type T.
/// </summary>
/// <typeparam name="T">The type of objects in the collection.</typeparam>
class Objs<T> : IEnumerable<T> where T : Base
{
    private List<T> items = new List<T>();

    /// <summary>
    /// Adds an item to the collection.
    /// </summary>
    /// <param name="item">The item to add.</param>
    public void Add(T item)
    {
        items.Add(item);
    }

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>An enumerator that can be used to iterate through the collection.</returns>
    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>An enumerator that can be used to iterate through the collection.</returns>
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

/// <summary>
/// Class for handling room objects and their actions.
/// </summary>
class RoomObjects
{
    /// <summary>
    /// Performs an action on the specified type of objects.
    /// </summary>
    /// <param name="roomObjects">The list of room objects.</param>
    /// <param name="type">The type of objects to interact with.</param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var obj in roomObjects)
        {
            if (type.IsAssignableFrom(obj.GetType()))
            {
                if (obj is IInteractive interactive)
                {
                    interactive.Interact();
                }
                else if (obj is IBreakable breakable)
                {
                    breakable.Break();
                }
                else if (obj is ICollectable collectable)
                {
                    collectable.Collect();
                }
            }
        }
    }
}
