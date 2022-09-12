using System;

class Program
{
    static void Main()
    {
        double[,] matrix2 = {{1, 2, 3}, {3, 4, 5}};
        int row = matrix2.GetLength(0);
        int col =  matrix2.GetLength(1);
        double[,] new_matrix = new double[row, col];

        new_matrix = MatrixMath.Transpose(matrix2);

        for (int x = 0; x < new_matrix.GetLength(0); x++)
        {
            for (int y = 0; y < new_matrix.GetLength(1); y++)
            {
                Console.WriteLine(new_matrix[x, y] + ", ");
            }
        }
    }
}