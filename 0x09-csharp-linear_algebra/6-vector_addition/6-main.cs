
using System;

class Program
{
    static void Main()
    {
        double[] v_2 = new double[] {3, 4};
        double[] v_2_add = new double[] {2, 2};
        double[] v_3 = new double[] {3, 4, 5};
        double[] v_3_add = new double[] {3, 7, 6};

        Console.WriteLine("({0})", VectorMath.Add(v_2, v_2_add));
        Console.WriteLine("({0})", VectorMath.Add(v_3, v_3_add));
    }
}