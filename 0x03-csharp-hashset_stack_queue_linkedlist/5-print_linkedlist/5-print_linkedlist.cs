using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> LL = new LinkedList<int>();
        if (size < 0)
        {
            return LL;
        }

        for (int num = 0; num < size; num++)
        {
            LL.AddLast(num);
            Console.WriteLine(num);
        }
        return LL;
    }
}