using System;
/// <summary>
/// Public Class MatrixMath
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Public Method Add to add two matrices
    /// </summary>
    /// <param name="matrix1"> 2D or 3D matrix </param>
    /// <param name="matrix2"> 2D or 3D matrix </param>
    /// <returns> new matrix </returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) == matrix2.GetLength(0) == 
            matrix1.GetLength(1) == matrix2.GetLength(1) == 2)
        {
            double[,] res = { { 0, 0 }, { 0, 0 } };
            int mat_l = matrix1.Length;
            for (int x = 0; x < mat_l; x++)
            {
                for (int y = 0; y < mat_l; y++)
                {
                    res[x, y] = matrix1[x, y] + matrix2[x, y];
                }
            }
            return (res);
        }
        else if (matrix1.GetLength(0) == matrix2.GetLength(0) == 
                 matrix1.GetLength(1) == matrix2.GetLength(1) == 3)
        {
            double[,] res = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            int mat_l = matrix1.Length;
            for (int x = 0; x < mat_l; x++)
            {
                for (int y = 0; y < mat_l; y++)
                {
                    res[x, y] = matrix1[x, y] + matrix2[x, y];
                }
            }
            return (res);
        }
        return new double[,] { { -1 } };
    }
}