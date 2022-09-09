using System;

class Program
{
    static void Main()
    {
        double[,] matrix2 = {{1, 2}, {3, 4}};
        double s_2 = 4;
        double[,] matrix3 = {{14, -3, 0}, {-11, -5, 3}, {2, -9, 13}};
        double s_3 = 0.5;

        Console.WriteLine("({0})", MatrixMath.MultiplyScalar(matrix2, s_2));
        Console.WriteLine("({0})", MatrixMath.MultiplyScalar(matrix3, s_3));
    }
}