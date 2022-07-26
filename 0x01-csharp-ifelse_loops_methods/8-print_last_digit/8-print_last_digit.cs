using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int last_dig = number % 10;
        Console.Write("{0}", Math.Abs(last_dig));
        return Math.Abs(last_dig);
    }
}