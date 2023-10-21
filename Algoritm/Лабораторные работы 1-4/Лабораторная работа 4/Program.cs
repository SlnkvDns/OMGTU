using System;

class Program
{
    static void Main()
    {
        double[] mas = { 1, 1.5 };
        double y = 0;
        foreach (double a in mas)
        {
            Console.WriteLine($"Для a = {a}:");
            for (double x = 0.1; x <= 1.6; x += a / 5.0)
            {
                if (x >= 0.1 && x <= 0.4)
                    y = Math.Sin(a * x) - Math.Sqrt(Math.Log10(a * a + x * x));
                else if (x > 0.4 && x <= 1.2)
                    y = a * Math.Cos(Math.PI * x) * Math.Cos(Math.PI * x);
                else if (x > 1.2 && x <= 1.6)
                    y = 2 - Math.Sin(a * x);
                Console.WriteLine($"x = {Math.Round(x,2)}: {y}"); 
            }
            Console.WriteLine();
        }
    }
}