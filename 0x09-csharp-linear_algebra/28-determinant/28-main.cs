using System;

class Program
{
    static void Main()
    {
        double[,] matrix2 = {{-4, 9, 0}, {1, -2, 1}, {3, -4, 2}};
        double determinant = 0;

        determinant = MatrixMath.Determinant(matrix2);
        
        Console.WriteLine(determinant);
    }
}