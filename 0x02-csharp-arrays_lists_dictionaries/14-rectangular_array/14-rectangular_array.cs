using System;

class Program
{
    static void Main(string[] args)
    {
        int i, j;
        int[,] arrays = new int[,] 
        { 
            {0, 0, 0, 0, 0}, 
            {0, 0, 0, 0, 0}, 
            {0, 0, 1, 0, 0}, 
            {0, 0, 0, 0, 0}, 
            {0, 0, 0, 0, 0}
        };

        for (i = 0; i < arrays.GetLength(0); i++)
        {
            for (j = 0; j < arrays.GetLength(1); j++)
            {
                Console.Write(arrays[i, j]);
                if (j != arrays.GetLength(1) - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}