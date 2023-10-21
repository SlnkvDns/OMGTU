using System;

class Program
{
    static void Main()
    {
        double x = Convert.ToDouble (Console.ReadLine());
        double a = 2.3, f = 0;
        if (x >= 0 && x <= 4)
        {
            if (x > 2)
                f = Math.Pow(x + a, 1.0 / 5);
            else if (x > 0.3 && x <= 2)
                f = x;
            else if (x <= 0.3)
                f = Math.Cos(x - a);
            Console.WriteLine(f);
        }
        else
            Console.WriteLine("x не принадлежит [0, 4]");
    }
}