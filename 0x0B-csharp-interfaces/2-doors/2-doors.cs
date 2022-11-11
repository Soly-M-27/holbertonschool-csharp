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
interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}
class Door : Base, IInteractive
{
    public Door(string name = "Door")
    {
        this.name = name;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}