
using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> x = new List<int>();
        for (int i = 0; i < list1.Count; i++ )
        {
            for (int j = 0; j < list2.Count; j++)
            {
                if (list1[i] == list2[j])
                {
                    x.Add(list1[i]);
                }
            }
        }
        return x;
    }
}