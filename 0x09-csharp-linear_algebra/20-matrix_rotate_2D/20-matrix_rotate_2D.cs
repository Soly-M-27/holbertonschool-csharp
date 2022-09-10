using System;

/// <summary> 
/// Public Class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Public Methods Rotate2D to rotate matrix by a given angle
    /// </summary>
    /// <param name="matrix"> matrix </param>
    /// <param name="angle"> angle to rotate matrix by </param>
    /// <returns> New rotation/transformation </returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(1) > 2)
            return new double[,] { { -1 } };
        double[,] transform = new double[2, 2];
        double[,] Rot_Matrix = { { Math.Cos(angle), Math.Sin(angle) }, { -1 * Math.Sin(angle), Math.Cos(angle) } };

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                    transform[i, j] = Math.Round(transform[i, j] + (matrix[i, k] * Rot_Matrix[k, j]), 2);
        return transform;
    }
}