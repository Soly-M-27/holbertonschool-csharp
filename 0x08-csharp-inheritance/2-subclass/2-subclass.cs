using System;
using System.Collections.Generic;

/// <summary>
/// Public Class Obj
/// </summary>
public class Obj
{
    /// <summary>
    /// Method that return true if derivedType is a subclass of 
    /// baseType, otherwise returns false
    /// </summary>
    /// <param name="derivedType"> Derived </param>
    /// <param name="baseType"> Base </param>
    /// <returns> True if sublclass of Base, false if not. </returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return (true);
        return (false);
    }
}
