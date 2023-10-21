using System;

class Program
{
    static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double a = 0.7, c = 2.1;
        double y = Math.Sin(x) / Math.Sqrt(1 + a * a * Math.Sin(x) * Math.Sin(x)) - c * Math.Log(a * x);
        Console.WriteLine(y);
    }
}

