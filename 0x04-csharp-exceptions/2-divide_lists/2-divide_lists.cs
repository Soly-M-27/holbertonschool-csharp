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
                new_list.Add(list1[x] / list2[x]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                new_list.Add(0);
            }
        }
        return (new_list);
    }
}
