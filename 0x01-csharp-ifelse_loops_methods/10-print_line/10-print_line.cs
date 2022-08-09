using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length > 0)
        {
            string str = new string('_', length);
            Console.Write(str + "\n");
        }
        else
        {
            Console.WriteLine();
        }
    }
}