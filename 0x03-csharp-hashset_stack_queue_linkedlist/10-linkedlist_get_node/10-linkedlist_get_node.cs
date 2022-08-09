using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int i = 0;
        LinkedList<int>.Enumerator num = myLList.GetEnumerator();
        while (num.MoveNext())
        {
            int res = num.Current;
            if (i == n)
            {
                return res;
            }
            i++;
        }
        return (0);
    }
}