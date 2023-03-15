using System;

///<summary>
/// A generic Queue class
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Declaration of private field properties
    /// </summary> 
    private Node head;
    private Node tail;
    private int count;
    
    /// <summary>
    /// public class called Node with properties:
    /// value: set initial value null, can be of any type
    /// next: set initial value null, must be an obj of type Node
    /// 
    /// Define a constructor that takes a value for a new Node as its 
    /// only parameter and sets it. 
    /// </summary>
    public class Node
    {
        public T value = default(T);

        /// <summary>
        /// Getter for the next variable of type Node, initially declared null
        /// </summary>
        public Node next = null;

        /// <summary>
        /// Constructor method for Node class
        /// </summary>
        /// <param name="value">Sets/Returns the value of a generic type parameter</param>
        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// Adds new Node at end of Queue
    /// </summary>
    /// <param name="value">Variable of generic type parameter already specified by client</param>
    public void Enqueue(T value)
    {
        Node new_Node = new Node(value);

        if (head == null)
        {
            head = tail = new_Node;
        }
        else
        {
            tail.next = new_Node;
            tail = new_Node;
        }
        count += 1;
    }

    /// <summary>
    /// Removes the first Node in the Queue and Returns its value
    /// </summary>
    /// <returns> The value of the first Node removed from Queue </returns>
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

    ///<summary>
    /// Returns the value of the first node in the queue 
    /// without removing it
    /// </summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    ///<summary>
    /// Returns created type from Queue class
    /// </summary> 
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Returns the total number of Nodes in the Queue
    /// </summary>
    /// <returns> Total number within count variable </returns>
    public int Count()
    {
        return count;
    }

    ///<summary>
    /// Prints the queue starting from the head
    /// </summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            tail = head;
            while (tail != null)
            {
                Console.WriteLine(tail.value);
                tail = tail.next;
            }
        }
    }
}