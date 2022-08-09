using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
        {
            return (0);
        }
        
        LinkedListNode<int> num = myLList.First;
        
        if (num == null)
        {
            return (0);
        }
        myLList.RemoveFirst();
        return (num.Value);
    }
}