using System;
using System.Collections;

/// <summary>
/// Public Class MatrixMath with Method Inverse2D
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Public Method Inverse2D to find the Identity Matrix
    /// </summary>
    /// <param name="matrix"> 2D matrix </param>
    /// <returns> Inverse Matrix or -1 if matrix is not 2D </returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2 &&
            (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) != 0)
        {
            double[,] Inverse_Matrix = new double[,] {{0, 0}, {0, 0}};
            double[,] new_temp_inverse = new double[,] {{0, 0}, {0, 0}};

            double a = matrix[0, 0];
            double b = matrix[0, 1];
            double c = matrix[1, 0];
            double d = matrix[1, 1];

            new_temp_inverse[0, 0] = d;
            new_temp_inverse[0, 1] = -b;
            new_temp_inverse[1, 0] = -c;
            new_temp_inverse[1, 1] = a;

            double formula = (1 / ((a * d) - (b * c)));

            for (int x = 0; x < matrix.GetLength(1); x++)
            {
                for (int y = 0; y < matrix.GetLength(0); y++)
                {
                    Inverse_Matrix[x, y] = Math.Round(formula * new_temp_inverse[x, y], 2);
                }
            }
            return Inverse_Matrix;
        }
        return new double[,] { { -1 } };
    }
}
