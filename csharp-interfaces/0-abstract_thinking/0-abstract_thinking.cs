using System;

public abstract class Base
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public override string ToString()
    {
        if (!string.IsNullOrEmpty(Name))
            return $"{Name} is a {GetType().Name}";
        else
            return $"{GetType().Name} (no name set)";
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
        Name = "Abstract Class"; // Setting the Name property
    }
}

class Program
{
    static void Main(string[] args)
    {
        var engineer = new SoftwareEngineer();
        Console.WriteLine(engineer);

        var testObjectWithName = new TestObject();
        Console.WriteLine(testObjectWithName);

        var testObjectWithoutName = new TestObject();
        testObjectWithoutName.Name = null;
        Console.WriteLine(testObjectWithoutName);
    }
}
