using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int total = 0;
        LinkedList<int>.Enumerator num = myLList.GetEnumerator();
        while (num.MoveNext())
        {
            int res = num.Current;
            total += res;
        }
        return (total);
    }
}