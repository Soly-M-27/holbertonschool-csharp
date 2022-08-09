using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> new_list = new List<int>();
        int div = 0;

        for (int x = 0; x < listLength; x++)
        {
            try
            {
                div = list1[x] / list2[x];
                new_list.Add(div);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of Range");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannit divide by zero");
                new_list.Add(0);
            }
        }
        return (new_list);
    }
}