using System;
/// <summary>
/// Public Class Matrix Math with Matrix Multiplication Method
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Public Method Multiply to multiply matrices
    /// </summary>
    /// <param name="matrix1"> multidimensional matrix </param>
    /// <param name="matrix2"> other possible multidimensional matrix</param>
    /// <returns> new matrix with multiplied values as result of previous matrices </returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int matrix1_row1 = matrix1.GetLength(0);
        int matrix1_col1 = matrix1.GetLength(1);
        int matrix2_row2 = matrix2.GetLength(0);
        int matrix2_col2 = matrix2.GetLength(1);

        double[,] new_matrix = new double[matrix1_row1, matrix2_col2];

        if (matrix1_col1 != matrix2_row2)
        {
            return new double[,] { { -1 } };
        }
        else
        {
            for (int x = 0; x < matrix1_row1; x++)
            {
                for (int y = 0; y < matrix2_col2; y++)
                {
                    for (int z = 0; z < matrix1_col1; z++)
                    {
                        new_matrix[x, y] = matrix1[x, z] * matrix2[z, y];
                    }
                }
            }
            return new_matrix;
        }
    }
}