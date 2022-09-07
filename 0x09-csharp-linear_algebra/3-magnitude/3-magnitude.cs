using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        double res = 0f;

        if (vector.GetType() != typeof(Vector2) && vector.GetType() != typeof(Vector3))
        {
            return (-1);
        }

        if (vector.GetType() == typeof(Vector2))
        {
            res = (Math.Sqrt(Math.Pow(vector.x, 2) + Math.Pow(vector.y, 2));
        }
        else if (vector.GetType() == typeof(Vector3))
        {
            res = (Math.Sqrt(Math.Pow(vector.x, 2) + Math.Pow(vector.y, 2) + Math.Pow(vector.z, 2));
        }
        
        return (Math.Round(res/100d, 0) * 100);
    }
}