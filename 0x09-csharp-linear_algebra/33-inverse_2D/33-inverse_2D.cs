using System;

/// <summary>
/// Public Class VectorMath with Method Inverse2D
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Public Method Inverse 2D to find the Identity Matrix
    /// </summary>
    /// <param name="matrix"> 2D matrix </param>
    /// <returns> Inverse Matrix or -1 if matrix is not 2D </returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2 &&
            (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) != 0)
        {
            //matrixes for formula and final result
            double[,] Inverse_Matrix = new double[2, 2];
            double[,] new_temp_inverse = new double[2, 2];

            //Setting up a, b, c and d for formula
            double a = matrix[0, 0];
            double b = matrix[0, 1];
            double c = matrix[1, 0];
            double d = matrix[1, 1];

            //Set up new inversed matrix for formula
            new_temp_inverse[0, 0] = d;
            new_temp_inverse[0, 1] = -b;
            new_temp_inverse[1, 0] = -c;
            new_temp_inverse[1, 1] = a;

            //Set up formula to be multiplied by new inversed matrix
            double formula = (1 / ((a*d) - (b*c)));

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Inverse_Matrix[x, y] = Math.Round(formula * new_temp_inverse[x, y], 2);
                }
            }
            return Inverse_Matrix;
        }
        return new double[,] {{-1}};
    }
}