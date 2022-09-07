using System;
using VectorMath;

class Program
{
    static void Main()
    {
        double Vector vector1 = new Vector(3, 4);
        double Vector vector2 = new Vector(3, 4, 5);

        Console.log(Magnitude(vector1));
    }
}