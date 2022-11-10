using System;

///<summary> Public class Player, representing an object (Player obj).</summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary>
    /// Constructor prototype method for Player.
    /// </summary>
    ///<param name="name"> name of player</param>
    ///<param name="maxHp">health points of player</param>
    ///
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp > 0)
            this.maxHp = maxHp;
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.name = name;
        this.hp = this.maxHp;
    }

    ///<summary>
    /// Prints the current health of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    ///<summary>
    /// Handles health related events
    /// </summary>
    public delegate void CalculateHealth(float points);

    /// <summary>
    /// Prints name takes damage damage!
    /// If damage is negative, the Player takes 0 damage 
    /// and prints name takes 0 damage!
    /// </summary>
    /// <param name="damage"> if it is negative, the Player takes 0 damage </param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
            Console.WriteLine($"{name} takes 0 damage!");
        else
        {
            Console.WriteLine($"{name} takes {damage} damage!");
            ValidateHP(hp - damage);
        }
    }
    
    /// <summary>
    /// Prints health points recovered
    /// </summary>
    /// <param name="heal"> If heal is negative, the Player heals 0 
    /// HP and prints name heals 0 HP!</param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
            Console.WriteLine($"{name} heals 0 HP!");
        else
            Console.WriteLine($"{name} heals {heal} HP!");
    }

    /// <summary>
    /// Sets the new value of the Player’s hp
    /// </summary>
    /// <param name="newHp"> if newHp is negative, set hp to 0. 
    ///                      If newHp is larger than maxHp, set hp to the value of maxHp.
    ///                      Otherwise, set hp to the value of newHp. </param>
    public void ValidateHP(float newHp)
    {
        if (newHp <= 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }
}