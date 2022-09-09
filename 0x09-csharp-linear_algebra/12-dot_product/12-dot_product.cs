using System;
/// <summary>
/// Public class VectorMath
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Public Method DotProduct, to find dot product in matrices by
    /// following the DotProduct Formula 
    /// </summary>
    /// <param name="vector1"> 2D or 3D vector </param>
    /// <param name="vector2"> 2D or 3D vector </param>
    /// <returns> vector with one element representing the total of the DotProduct </returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double res = 0;
            res = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]);
            return (res);
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double res = 0;
            res = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]);
            return (res);
        }
        return (-1);
    }
}