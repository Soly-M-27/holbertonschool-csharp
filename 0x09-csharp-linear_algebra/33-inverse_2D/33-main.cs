using System;

class Program
{
    static void Main()
    {
        double[,] matrix2 = {{1, 2}, {3, 4}};
        double[,] inverse = VectorMath.Inverse2D(matrix2);

        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                Console.WriteLine(inverse[x, y]);
            }
        }
    }
}