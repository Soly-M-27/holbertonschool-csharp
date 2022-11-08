using System;

///<summary>A generic Queue class</summary>
public class Queue<T>
{
    ///<summary>Returns created type from Queue class</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}