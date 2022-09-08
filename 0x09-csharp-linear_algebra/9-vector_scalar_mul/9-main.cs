class Program
{
    static void Main()
    {
        double[] v_2 = new double[] {98, 972};
        double s_2 = 0.5;
        double[] v_3 = new double[] {0, -16, 31};
        double s_3 = 4.0;

        Console.WriteLine("({0})", VectorMath.Multiply(v_2, s_2));
        Console.WriteLine("({0})", VectorMath.Multiply(v_3, s_3));
    }
}