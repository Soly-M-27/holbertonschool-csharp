using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> list = new List<int>();
        
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        
        for (int x = 0; x < size; x++)
        {
            list.Add(x);
            Console.Write(list[x]);
            if (x != size - 1)
            {
                Console.Write(" ");
            }
        }
    
    Console.WriteLine();
    return list;
    }
}