using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        var myHashSet = new HashSet<int>();

        foreach (int number in myList)
        {
            myHashSet.Add(number);
        }

        foreach (int uniqueNumber in myHashSet)
        {
            sum += uniqueNumber;
        }
        return (sum);
    }
}