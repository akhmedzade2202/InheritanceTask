
class Program
{
    // 1.Çevrənin sahəsi - S = 3 * r^2
    static double CircleArea(double r)
    {
        return 3 * r * r;
    }

    // 2.Düzbucaqlının sahəsi - S = a * b
    static double RectangleArea(double a, double b)
    {
        return a * b;
    }

    // 3.Düzbucaqlı paralelpipedin tam səthinin sahəsi - S=2(a*b + a*c + b*c)
    static double RectangularPrismSurfaceArea(double a, double b, double c)
    {
        return 2 * (a * b + a * c + b * c);
    }

    // 4.Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S = p * r; p = (a+b+c)/2
    static double IncircleAreaOfTriangle(double a, double b, double c, double r)
    {
        double p = (a + b + c) / 2;
        return p * r;
    }

    static void Main()
    {
        Console.WriteLine("Cevrenin sahesi: " + CircleArea(5)); 
        Console.WriteLine("Duzbucaqlinin sahesi: " + RectangleArea(4, 6));
        Console.WriteLine("Duzbucaqli paralelipipedin sahesi: " + RectangularPrismSurfaceArea(3, 4, 5));
        Console.WriteLine("Ucbucaqlinin daxiline cekilmis cevrenin sahesi: " + IncircleAreaOfTriangle(3, 4, 5, 2)); 
    }
}
