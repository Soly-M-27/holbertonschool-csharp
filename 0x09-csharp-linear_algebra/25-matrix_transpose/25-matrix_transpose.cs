using System;

/// <summary>
/// Public Class MatrixMath with Transpose Method
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Public Method Transpose to switch rows and colums of entering matrix
    /// </summary>
    /// <param name="matrix"> matrix </param>
    /// <returns> new transposed matrix </returns>
    public static double[,] Transpose(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        double[,] transposedMatrix = new double[col, row];

        for (int x = 0; x < row; x++)
        {
            for (int y = 0; y < col; y++)
            {
                transposedMatrix[y, x] = matrix[x, y];
            }
        }
        return transposedMatrix;
    }
}