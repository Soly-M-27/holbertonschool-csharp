using System;
using System.Collections.Generic;

/// <summary>
/// Public class VectorMath
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Public static method for the Magnitude of a 2D or 3D vector
    /// </summary>
    /// <param name="vector"> 2D or 3D vector </param>
    /// <returns> Rounded to the 100th double representing vector magnitude </returns>
    public static double Magnitude(double[] vector)
    {
        double res = 0f;

        if (vector.Length > 3 || vector.Length <= 1)
        {
            return (-1);
        }

        if (vector.Length == 2)
        {
            res = Math.Sqrt(Math.Pow(Math.Abs(vector[0]), 2) + Math.Pow(Math.Abs(vector[1]), 2));
        }
        else if (vector.Length == 3)
        {
            res = Math.Sqrt(Math.Pow(Math.Abs(vector[0]), 2) + Math.Pow(Math.Abs(vector[1]), 2) + Math.Pow(Math.Abs(vector[2]), 2));
        }

        return (Math.Round(res / 100d, 0) * 100);
    }
}
