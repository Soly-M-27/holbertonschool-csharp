using System;
using System.Collections.Generic;

class List
{    
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;

        try
        {
            for (int x = 0; x < n; x++)
            {
                Console.WriteLine("{0:D}", myList[x]);
                count++;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            n = myList.Count;
            return (n);
        }
        return (count);
    }
}
