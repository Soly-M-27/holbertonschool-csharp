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
		int matric1_col1 = matrix1.GetLength(1);
		int matrix2_row2 = matrix2.GetLength(0);
		int matrix2_col2 = matrix2.GetLength(1);
        double[,] matrix3 = new double[matrix1_row1, matrix2_col2];

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] {{-1}};
        else
		{
			for (int i = 0; i < row1; i++)
				for (int j = 0; j < col2; j++)
					for (int k = 0; k < col1; k++)
						matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
			return matrix3;
		}
	}
}