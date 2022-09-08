using System;

class Program
{
    static void Main()
    {
        double[] v_2 = new double[] {3, 4};
        double[] v_3 = new double[] {3, 4, 5};

        Console.WriteLine(VectorMath.Magnitude(v_2));
        Console.WriteLine(VectorMath.Magnitude(v_3));
    }
}