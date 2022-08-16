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

    /// <summary>
    /// public override for Area methos on base class
    /// </summary>
    /// <returns> Area </returns>
    public override int Area()
    {
        return Width * Height;
    }

    /// <summary>
    /// public override of ToString method
    /// </summary>
    /// <returns> String overriden </returns>
    public override string ToString()
    {
        return $"[Rectangle] {Width} / {Height}";
    }

}

/// <summary>
/// Class Square
/// </summary>
class Square
{
    private int size;
    /// <summary>
    /// public int Size property
    /// </summary>
    public int Size
    {
        get => size;
        set
        {
            size = Height = Width = (value < 0) ? throw new ArgumentException("Size must be greater than or equal to 0") : size = Height = Width = value;
        }
    }
}
