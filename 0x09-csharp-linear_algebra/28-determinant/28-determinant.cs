using System;

/// <summary>
/// Public Class MatrixMath with Determinant Method
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Public Determinant Method to get matrix determinant
    /// </summary>
    /// <param name="matrix"> 2D or 3D Matrix </param>
    /// <returns> Determinant or -1 </returns>
	public static double Determinant(double[,] matrix)
	{
		if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
			return (Math.Round(((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0])), 2));
		else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
		{
			double left = matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]));
			double center = matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]));
			double right = matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]));
			return Math.Round((left - center + right), 2);
		}
		return (-1);
	}
}