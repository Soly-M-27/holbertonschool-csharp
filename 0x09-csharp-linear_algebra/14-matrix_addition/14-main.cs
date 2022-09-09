using System;

class Program
{
    static void Main()
    {
        double[,] matrix2 = {{1, 2}, {3, 4}};
        double[,] m_2 = {{-2, 5}, {1, 7}}; 
        double[,] matrix3 = {{14, -3, 0}, {-11, -5, 3}, {2, -9, 13}};
        double[,] m_3 = {{6, 16, 21}, {5, 2, 0}, {1, 3, 7}};

        Console.WriteLine("({0})", MatrixMath.Add(matrix2, m_2));
        Console.WriteLine("({0})", MatrixMath.Add(matrix3, m_3));
    }
}