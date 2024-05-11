using System;
using System.Reflection;

public class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();

        Console.WriteLine($"{type.Name} Properties:");
        foreach (var property in type.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine($"{type.Name} Methods:");
        foreach (var method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
