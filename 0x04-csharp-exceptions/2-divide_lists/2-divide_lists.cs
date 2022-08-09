using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> new_list = new List<int>();

        for (int x = 0; x < listLength; x++)
        {
            try
            {
                newList.Add(list1[x] / list2[x]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                new_list.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return (new_list);
    }
}
