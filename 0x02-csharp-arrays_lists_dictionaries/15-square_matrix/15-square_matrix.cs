using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int i, j;
        int [,] new_matrix = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];
        for (i = 0; i < myMatrix.GetLength(0); i++)
        {
            for (j = 0; j < myMatrix.GetLength(1); j++)
            {
                new_matrix[i,j] = (myMatrix[i, j] * myMatrix[i, j]);
            
            }
        }
        return new_matrix;
    }
}