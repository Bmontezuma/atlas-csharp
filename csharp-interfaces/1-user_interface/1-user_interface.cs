using System;
using System.Reflection;

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
/// An interface for breakable objects.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Property representing the durability of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Method for breaking the object.
    /// </summary>
    void Break();
}

/// <summary>
/// An interface for collectable objects.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Property representing whether the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Method for collecting the object.
    /// </summary>
    void Collect();
}

/// <summary>
/// Represents a test object inheriting from Base and implementing all three interfaces.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact() { }
    public void Break() { }
    public void Collect() { }

    static void Main(string[] args)
    {
        TestObject item = new TestObject();
        Type type = item.GetType();

        Console.WriteLine("Type: " + type);

        Console.WriteLine("Properties:");
        foreach (PropertyInfo info in type.GetProperties())
            Console.WriteLine(info.Name);

        Console.WriteLine("Methods:");
        foreach (MethodInfo info in type.GetMethods())
            Console.WriteLine(info.Name);
    }
}
