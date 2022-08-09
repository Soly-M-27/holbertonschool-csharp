using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> new_node = new LinkedListNode<int>(n);
        LinkedListNode<int> current_node;

        if (myLList == null)
        {
            return (null);
        }

        if (myLList.Count == 0)
        {
            myLList.AddFirst(new_node);
        }
        else
        {
            current_node = myLList.First;
            while (current_node != null)
            {
                if (current_node.Value > n)
                {
                    myLList.AddBefore(current_node, new_node);
                    break;
                }

                current_node = current_node.Next;
            }
            
            if (current_node == null)
            {
                myLList.AddLast(new_node);
            }
        }

        return (new_node);
    }
}