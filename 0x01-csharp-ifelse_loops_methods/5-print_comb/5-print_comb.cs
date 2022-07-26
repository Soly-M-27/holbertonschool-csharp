using System;

class Program
{
    static void Main(string[] args)
    {
        for (int xer = 0; xer <= 99; xer++)
        {
            Console.Write(string.Format("{0:00}, ", xer));
        }
        Console.Write("99\n");
    }
}