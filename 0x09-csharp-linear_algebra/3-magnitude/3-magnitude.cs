using System;

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

        if (vector.GetType() !=  && vector.GetType() != typeof(Vector3))
        {
            return (-1);
        }

        if (vector.GetType() == typeof(Vector2))
        {
            res = Math.Sqrt(Math.Pow(vector.x, 2) + Math.Pow(vector.y, 2));
        }
        else if (vector.GetType() == typeof(Vector3))
        {
            res = Math.Sqrt(Math.Pow(vector.x, 2) + Math.Pow(vector.y, 2) + Math.Pow(vector.z, 2));
        }

        return (Math.Round(res / 100d, 0) * 100);
    }
}
