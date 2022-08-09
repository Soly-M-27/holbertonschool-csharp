using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int i = 0;
        LinkedList<int>.Enumerator num = myLList.GetEnumerator();
        while (num.MoveNext())
        {
            int res = num.Current;
            if (res == value)
            {
                return i;
            }
            i++;
        }
        return (-1);
    }
}