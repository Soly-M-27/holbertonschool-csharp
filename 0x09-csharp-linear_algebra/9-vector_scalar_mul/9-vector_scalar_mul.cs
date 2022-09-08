using System;

/// <summary>
/// Public Class VectorMath
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Public Method to Multiply 2D or 3D vectors by respective scalar 
    /// </summary>
    /// <param name="vector"> 2D or 3D vector </param>
    /// <param name="scalar"> scalar to multiply on all vector elements </param>
    /// <returns> new vector multiplied by scalar </returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2 || vector.Length == 3)
        {
            if (vector.Length == 2)
            {
                double[] res = {0, 0};
                int vec_l = vector.Length;
                for (int x = 0; x < vec_l; x++)
                {
                    res[x] = vector[x] * scalar;
                }
                return (res);
            }
            else if (vector.Length == 3)
            {
                double[] res = {0, 0, 0};
                int vec_l = vector.Length;
                for (int x = 0; x < vec_l; x++)
                {
                    res[x] = vector[x] * scalar;
                }
                return (res);
            }
        }
        return new double[1] {-1};
    }
}