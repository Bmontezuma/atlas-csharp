using System;

/// <summary>
/// An interface for interactive objects.
/// </summary>
public interface IInteractive
{
    void Interact();
}

/// <summary>
/// An interface for breakable objects.
/// </summary>
public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// An interface for collectable objects.
/// </summary>
public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// A class representing a software engineer.
/// </summary>
class SoftwareEngineer : Base
{
    // Empty class
}

/// <summary>
/// A class representing a test object inheriting from Base and implementing the interfaces IInteractive, IBreakable, and ICollectable.
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public bool isCollected { get; set; }
    public int durability { get; set; }

    public void Interact() { }
    public void Break() { }
    public void Collect() { }
}
