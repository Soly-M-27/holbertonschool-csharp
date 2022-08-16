using System;
using System.Collections.Generic;

/// <summary>
/// Public Class Obj and its methods
/// </summary>
public class Obj
{
    /// <summary>
    /// Method that returns True if object is an instance of, or if the object
    /// is an instance of class that inherited from, Array, otherwise return False. 
    /// </summary>
    /// <param name="obj"> object to be checked </param>
    /// <returns> True if object is of instance of a class inherited from Array, otherwise False </returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return (obj is Array);
    }
}
