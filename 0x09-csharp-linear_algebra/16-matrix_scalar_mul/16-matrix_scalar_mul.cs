using System;
/// <summary>
/// Public Class MatrixMath with Methods MultiplyScalar
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Public Method MultiplyScalar with multiplies a scalar by a 2D or 3D matrix
    /// </summary>
    /// <param name="matrix"> 2D or 3D matrix </param>
    /// <param name="scalar"> double scalar to use in multiplication </param>
    /// <returns> new matrix with the result from scalar multiplication </returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if ((matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) || (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3))
        {
            if (matrix.GetLength(0) == 2)
            {
                double[,] res = {{0, 0}, {0, 0}};
                int mat_l = 2;
                for (int x = 0; x < mat_l; x++)
                {
                    for (int y = 0; y < mat_l; y++)
                    {
                        res[x, y] = matrix[x, y] * scalar;
                    }
                }
                return (res);
            }   
            else if (matrix.GetLength(0) == 3)
            {
                double[,] res = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}};
                int mat_l = 3;
                for (int x = 0; x < mat_l; x++)
                {
                    for (int y = 0; y < mat_l; y++)
                    {
                        res[x, y] = matrix[x, y] * scalar;
                    }
                }
                return (res);
            }   
        }
        return new double[,] {{-1}};
    }
}