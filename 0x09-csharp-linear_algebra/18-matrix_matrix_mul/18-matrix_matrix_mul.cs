using System;

///<summary>
/// Public Class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Public Method Multiply to multiply two matrices of different dimensions
    /// </summary>
    /// <param name="matrix1"> matrix </param>
    /// <param name="matrix2"> other matrix </param>
    /// <returns> new matrix or -1 </returns>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		int matrix1_row1 = matrix1.GetLength(0);
		int matrix1_col1 = matrix1.GetLength(1);
		int matrix2_row2 = matrix2.GetLength(0);
		int matrix2_col2 = matrix2.GetLength(1);
        double[,] matrix3 = new double[matrix1_row1, matrix2_col2];

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] {{-1}};
        else
		{
			for (int x = 0; x < matrix1_row1; x++)
			{
				for (int y = 0; y < matrix2_col2; y++)
				{
					for (int z = 0; z < matrix1_col1; z++)
					{
						matrix3[x, y] += matrix1[x, z] * matrix2[z, y];
					}
				}
			}
			return matrix3;
		}
	}
}