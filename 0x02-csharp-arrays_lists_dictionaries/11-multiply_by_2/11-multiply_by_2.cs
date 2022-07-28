using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (var num in myDict)
        {
             dict.Add(num.Key, num.Value * 2);
        }
        return dict;
    }  
}