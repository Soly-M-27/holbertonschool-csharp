using System;
using System.Collections.Generic;

/// <summary>
/// Public class Obj
/// </summary>
public class Obj
{
    /// <summary>
    /// Method that returns True if obj is of type int
    /// </summary>
    /// <param name="obj"> object </param>
    /// <returns> True if obj is of type in, False otherwise </returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return (true);
        
        return (false);
    }
}
