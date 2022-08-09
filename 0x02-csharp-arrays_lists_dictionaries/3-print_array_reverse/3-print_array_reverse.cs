using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array is null || array.Length == 0)
        {
            Console.WriteLine();
        }

        else
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0:D}", array[i]);
                if (i != 0)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}