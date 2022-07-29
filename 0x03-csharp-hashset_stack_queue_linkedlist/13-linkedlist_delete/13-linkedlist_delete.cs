using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> num = myLList.First;
        for (int i = 0; i <= index && num != null; i++)
        {
            if (i != index)
            {
                num = num.Next;
                continue;
            }   
            myLList.Remove(num);
        }
    }
}