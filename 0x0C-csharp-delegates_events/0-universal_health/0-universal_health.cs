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
}