using System;

class Program
{
    static void Main(string[] args)
    {
        for (int x = 0; x <= 98; x++)
        {
            Console.Write("{0:D} = 0x{0:X}\n", x);
        }
    }   
}