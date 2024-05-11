using System;

public class Obj
{
    /// <summary>
    /// Checks if the specified type is a subclass of the specified base type.
    /// </summary>
    /// <param name="derivedType">The derived type to check.</param>
    /// <param name="baseType">The base type to check against.</param>
    /// <returns>True if the derived type is a subclass of the base type and not the same as the base type, otherwise False.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType) && derivedType != baseType;
    }
}
