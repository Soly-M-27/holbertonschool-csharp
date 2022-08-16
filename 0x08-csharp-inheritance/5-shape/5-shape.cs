using System;

/// <summary>
/// Class Shape
/// </summary>
class Shape
{
    /// <summary>
    /// Method to throw new exception
    /// </summary>
    /// <returns> throw new NotImplementedException </returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}