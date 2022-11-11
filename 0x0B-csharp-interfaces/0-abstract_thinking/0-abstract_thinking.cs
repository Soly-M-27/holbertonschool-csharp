using System;

/// <summary>
/// Abstract Class named Base which SoftwareEnginer will inherit
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Public Property String called "name"
    /// </summary>
    /// <value>string</value>
    public string name { get; set; }
    
    /// <summary>
    /// Public override string ToString method to return string
    /// </summary>
    /// <returns>String: "{name} is a {type}"</returns>
    public override string ToString()
    {
        Type type = this.GetType();

        return ($"{name} is a {type}");
    }
}