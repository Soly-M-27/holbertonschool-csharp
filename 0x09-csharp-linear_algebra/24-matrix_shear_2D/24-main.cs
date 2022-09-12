using System;

class Program
{
    static void Main()
    {
        double[,] matrix2 = {{1, 2}, {3, 4}};
        int row = matrix2.GetLength(0);
        int col =  matrix2.GetLength(1);
        double [,] new_matrix = new double[row, col];
        char letter = 'x';
        double shear_2D = 2;

        new_matrix = MatrixMath.Shear2D(matrix2, letter, shear_2D);

        for (int x = 0; x < new_matrix.GetLength(0); x++)
        {
            for (int y = 0; y < new_matrix.GetLength(1); y++)
            {
                Console.WriteLine(new_matrix[x, y] + ", ");
            }
        }

        letter = 'y';
        
        new_matrix = MatrixMath.Shear2D(matrix2, letter, shear_2D);

        for (int x = 0; x < new_matrix.GetLength(0); x++)
        {
            for (int y = 0; y < new_matrix.GetLength(1); y++)
            {
                Console.WriteLine(new_matrix[x, y] + ", ");
            }
        }
    }
}