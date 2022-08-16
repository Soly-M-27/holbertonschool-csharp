using System;
using System.Collections.Generic;

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

class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// public int Width
    /// </summary>
    public int Width 
    { 
        get => width;
        set { 
            width = (value < 0) ? throw new ArgumentException("Width must be greater than or equal to 0") : width = value; 
            }     
    }
    /// <summary>
    /// public int Height
    /// </summary>
    /// <value> height </value>
    public int Height 
    {
        get => height;
        set {
            height = (value < 0) ? throw new ArgumentException("Height must be greater than or equal to 0") : height = value;
            }
    }
}
