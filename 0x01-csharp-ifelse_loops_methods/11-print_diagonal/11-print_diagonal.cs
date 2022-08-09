using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
        {
            Console.WriteLine();
        }

        for (int x = 0; x < length; x++)
        {
            for (int y = 0; y < x; y++)
            {
                Console.Write(" ");
            }
            Console.Write("\\");
            Console.WriteLine();
        }
    }
}