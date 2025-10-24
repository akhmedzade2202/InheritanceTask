using System;

class MathOperations
{
    static double Power(double x)
    {
        return x * x;
    }

    static double Power(double x, int y)
    {
        double result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Kvadrat (5): " + Power(5));
        Console.WriteLine("Qüvvət (2^3): " + Power(2, 3));
    }
}
