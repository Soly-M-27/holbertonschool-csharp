using System;

///<summary>This class represents a Player object.</summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    ///<summary>Default constructor method.</summary>
    ///
    ///<param name="name">The name of the player</param>
    ///<param name="maxHp">Represents the health points of the player</param>
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
        HPCheck += CheckStatus;
    }

    ///<summary>Prints the current health of the player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    ///<summary>Handles health related events</summary>
    public delegate void CalculateHealth(float points);

    ///<summary>Prints damage taken</summary>
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
        ValidateHP(hp);
    }

    ///<summary>Prints health points recovered</summary>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            heal = 0;
        }
        else
            Console.WriteLine($"{name} heals {heal} HP!");
        hp += heal;
        ValidateHP(hp);
    }

    ///<summary>Sets the new value of HP</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp <= 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
        OnCheckStatus(new CurrentHPArgs(hp));
    }

    ///<summary>Calculate and </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue * 0.5f;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
    }
    
    public event EventHandler<CurrentHPArgs> HPCheck;

    private void CheckStatus(object sender, CurrentHPArgs e)
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

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
            Console.ForegroundColor = ConsoleColor.White;

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Health is low!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp <= (maxHp / 4))
            HPCheck += HPValueWarning;
        else
            HPCheck -= HPValueWarning;
        HPCheck(this, e);
    }
}

class CurrentHPArgs : EventArgs
{
    public float currentHp { get; }

    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

enum Modifier
{
    Weak,
    Base,
    Strong
}

delegate float CalculateModifier(float baseValue, Modifier modifier);