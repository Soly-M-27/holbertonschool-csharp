using System;

class Program
{
    static void Main(string[] args)
    {
        for (int x = 0; x <= 7; x++)
        {
            for (int y = 0; y <= 9; y++)
            {
                if (x < y && x != y)
                {
                    Console.Write("{0}{1}, ", x, y);
                }
            }
        }
        Console.WriteLine("89");
    }
}