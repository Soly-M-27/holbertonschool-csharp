using System;

/// <summary>
/// Public Class VectorMath
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Public method to add two vectors of the same dimensions
    /// </summary>
    /// <param name="vector1"> 2D or 3D vector </param>
    /// <param name="vector2"> 2D or 3D vector </param>
    /// <returns> New vector from added vectors or -1 otherwise </returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if ((vector1.Length > 3 || vector1.Length <= 1) || (vector2.Length > 3 || vector2.Length <= 1))
        {
            return (new double[1] {-1});
        }
        
        if ((vector1.Length == 2 && vector2.Length == 3) || (vector1.Length == 3 && vector2.Length == 2))
        {
            return (new double[1] {-1});
        }

        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] res = { 0, 0 };
            res[0] = vector1[0] + vector2[0];
            res[1] = vector1[1] + vector2[1];
            return (res);
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] res = { 0, 0, 0 };
            res[0] = vector1[0] + vector2[0];
            res[1] = vector1[1] + vector2[1];
            res[2] = vector1[2] + vector2[2];
            return (res);
        }

        return (new double[] {-1});
    }
}