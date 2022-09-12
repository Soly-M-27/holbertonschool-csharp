using System;

/// <summary>
/// Publuc Class VectorMath with CrossProduct Method
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Public Method CrossProduct between two vectors
    /// </summary>
    /// <param name="vector1"> 3D vector </param>
    /// <param name="vector2"> 3D vector </param>
    /// <returns> Cross Product of the vectors or -1 </returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] v_3 = {0, 0, 0};
            v_3[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1]; 
            v_3[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
            v_3[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];
            return v_3;
        }
        return new double[1] {-1};
    }
}