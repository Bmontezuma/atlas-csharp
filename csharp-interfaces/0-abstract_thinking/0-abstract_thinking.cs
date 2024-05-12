using System;

/// <summary>
/// An abstract class representing a base entity.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the entity.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Returns a string representation of the entity.
    /// </summary>
    /// <returns>A string in the format '<see cref="Name"/> is a <see cref="T:Base"/>'.</returns>
    public override string ToString()
    {
        return $"{Name} is a {GetType().Name}";
    }
}

public class SoftwareEngineer : Base
{
    public SoftwareEngineer()
    {
        Name = "Betty"; // Setting the Name property
    }
}

public class TestObject : Base
{
    public TestObject()
    {
        Name = "Abstract Classes"; // Setting the Name property
    }
}

class Program
{
    static void Main(string[] args)
    {
        var engineer = new SoftwareEngineer();
        Console.WriteLine(engineer);

        var testObject = new TestObject();
        Console.WriteLine(testObject);
    }
}

/// <summary>
/// Represents a test object with no name set.
/// </summary>
public class TestObjectNoName : Base
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TestObjectNoName"/> class.
    /// </summary>
    public TestObjectNoName()
    {
        // Name property not set intentionally
    }
}
