using System;

class Program
{
    static void Main()
    {
        double vector1 = new Vector(3, 4);
        double vector2 = new Vector(3, 4, 5);

        Console.log(VectorMath.Magnitude(vector1));
        Console.log(VectorMath.Magnitude(vector2));
    }
}