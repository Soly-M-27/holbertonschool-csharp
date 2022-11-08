using System;

///<summary>A generic Queue class</summary>
public class Queue<T>
{
    private Node head;
    private Node tail;
    private int count;

    ///<summary>A Node class implementation within a Queue</summary>
    public class Node
    {
        ///<summary>The value inside of the node</summary>
        public T value = default(T);
        ///<summary>The node that follows, if none value is null</summary> 
        public Node next = null;

        ///<summary>Constructor method for a Node class</summary>
        public Node(T value)
        {
            this.value = value;
        }
    }

    ///<summary>Adds a new node at the end of the queue</summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count += 1;
        
    }

    ///<summary>Removes the first node in the queue and returns the value</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            tail.value = head.value;
            head = head.next;
            count -= 1;
            return tail.value;
        }
    }

    ///<summary>Returns the type of the Queue that was created</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summary>Returns the number of nodes in the queue</summary>
    public int Count()
    {
        return count;
    }
}