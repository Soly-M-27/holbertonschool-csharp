using System;

class Program
{
    static void Main()
    {
        double[] v_1 = {2, -2, 1};
        double[] v_2 = {-8, 8, -4};
        double[] v_crossProd = VectorMath.CrossProduct(v_1, v_2);

        Console.WriteLine("{0}", v_crossProd);
    }
}