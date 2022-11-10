using System;

///<summary> Public class Player, representing an object (Player obj).</summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// New EventHandler of type CurrentHPArgs called HPCheck
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    private string status;

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
        this.status = $"{this.name} is ready to go!";
        HPCheck = CheckStatus;
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
        {
            Console.WriteLine($"{name} takes 0 damage!");
            damage = 0;
        }
        else
            Console.WriteLine($"{name} takes {damage} damage!");
        hp -= damage;
        ValidateHP(hp - damage);
    }
    
    /// <summary>
    /// Prints health points recovered
    /// </summary>
    /// <param name="heal"> If heal is negative, the Player heals 0 
    /// HP and prints name heals 0 HP!</param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            heal = 0;
        }
        else
        {
            Console.WriteLine($"{name} heals {heal} HP!");
        }
        hp += heal;
        ValidateHP(hp);
    }

    /// <summary>
    /// Sets the new value of the Player’s hp
    /// </summary>
    /// <param name="newHp"> if newHp is negative, set hp to 0. 
    /// If newHp is larger than maxHp, set hp to the value of maxHp.
    /// Otherwise, set hp to the value of newHp. </param>
    public void ValidateHP(float newHp)
    {
        if (newHp <= 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
        HPCheck(this, new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Follows the delegate prototype of CalculateModifier
    /// </summary>
    /// <param name="baseValue">specified by Main</param>
    /// <param name="modifier">Weak, Base or Strong, each will return the baseValue
    /// float variable with certain amplifications</param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue * 0.5f;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
    }

    /// <summary>
    /// Lets Player know how their health status is in word form,
    /// varying in the damage taken.
    /// </summary>
    /// <param name="sender">Object sent</param>
    /// <param name="e">EventHandler arguements</param>
    private void CheckStatus(object? sender, BindingManagerDataErrorEventArgsCurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            status = $"{name} is in perfect health!";
        else if (e.currentHp >= (maxHp / 2) && e.currentHp < maxHp)
            status = $"{name} is doing well!";
        else if (e.currentHp >= (maxHp / 4) && e.currentHp < (maxHp / 2))
            status = $"{name} isn't doing too great...";
        else if (e.currentHp > 0 && e.currentHp < (maxHp / 4))
            status = $"{name} needs help!";
        else
            status = $"{name} is knocked out!";
        Console.WriteLine(status);
    }
}

/// <summary>
/// Create an enum Modifier with the values Weak, Base, Strong.
/// </summary>
enum Modifier
{
    Weak,
    Base,
    Strong
}

/// <summary>
/// Delegate Method named CalculateModifier used in Main to declare
/// the ApplyModifier method within the delegate method parameter through
/// newly declared Player: "Electric Mouse". 
/// </summary>
/// <param name="baseValue">specified in Main</param>
/// <param name="modifier">will target words Weak, Base, Strong</param>
/// <returns></returns>
delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// New class CurrentHPArgs that inherits from EventArgs.
/// Properties: 
/// currentHp: public float that cannot be modified
/// Constructor:
/// Takes a float newHp and sets it as currentHp‘s value
/// </summary>
class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Properties: 
    /// currentHp: public float that cannot be modified
    /// </summary>
    /// <value>public float that cannot be modified, null if not provided</value>
    public float currentHp { get; }

    /// <summary>
    /// Constructor:
    /// Takes a float newHp and sets it as currentHp‘s value 
    /// </summary>
    /// <param name="newHp">sets it as currentHp‘s value</param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}