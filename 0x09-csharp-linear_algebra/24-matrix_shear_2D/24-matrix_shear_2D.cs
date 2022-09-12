using System;

/// <summary>
/// Public Class Matrix Math with Shear2D Method
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Public Shear2D Method where we factor in the shear onto the matrix,
    /// moving through the x or y axis and transform the matrix.
    /// </summary>
    /// <param name="matrix"> 2D matrix </param>
    /// <param name="direction"> x or y axis direction </param>
    /// <param name="factor"> Shear to factor in </param>
    /// <returns> new matrix or -1 if matrix is not of correct size </returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] new_matrix = new double[2, 2];

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            if (direction == 'x' || direction == 'X')
            {
                new_matrix[0, 0] = matrix[0, 0] + matrix[0, 1] * factor;
                new_matrix[0, 1] = matrix[0, 1];
                new_matrix[1, 0] = matrix[1, 0] + matrix[1, 1] * factor;
                new_matrix[1, 1] = matrix[1, 1];
                return new_matrix;
            }
            else if (direction == 'y' || direction == 'Y')
            {
                new_matrix[0, 0] = matrix[0, 0];
                new_matrix[0, 1] = factor * matrix[0, 0] + matrix[0, 1];
                new_matrix[1, 0] = matrix[1, 0];
                new_matrix[1, 1] = factor * matrix[1, 0] + matrix[1, 1]; 
                return new_matrix;
            }
            else
                return new double[,] {{-1}};
        }   
        return new double[,] {{-1}};
    }
}
