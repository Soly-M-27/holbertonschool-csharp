using System;
class Program
{
    static void Main()
    {
        double[] v_2 = new double[2] {1, 3};
        double[] s_2 = new double[2] {-2, 5}; 
        double[] v_3 = new double[3] {-4, 0, 10};
        double[] s_3 = new double[3] {3, 7, -9};

        Console.WriteLine("({0})", VectorMath.DotProduct(v_2, s_2));
        Console.WriteLine("({0})", VectorMath.DotProduct(v_3, s_3));
    }
}