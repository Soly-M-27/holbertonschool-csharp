using System;

class Program
{
    static void Main(string[] args)
    {
        for (int x = 0; x <= 99; x++)
        {
            Console.Write(string.Format("{0:00}, ", x));

        }
        Console.Write("99/n");
    }
}