using System;

class Program
{
    static void Main()
    {
        zadanie1();
        zadanie2();
    }

    static void zadanie1()
    {
        Console.WriteLine("1 задание");
        int n = 10;
        ulong z = 1;
        for (ulong i = 2, j = 0; j < (ulong)n; i += 2, j++)
            z *= i;
        Console.WriteLine(z + "\n");
    }

    static void zadanie2()
    {
        Console.WriteLine("2 задание\n");

        // Значения округлены до 2 знаков после запятой
        Console.WriteLine("f1 = sqrt(exp(x)-1)\n");
        for (double x = 1; x <= 3; x += 2.0 / 15)
        {
            double f1 = Math.Sqrt(Math.Exp(x) - 1.0);
            Console.WriteLine($"x = {Math.Round(x, 2)}: {Math.Round(f1, 2)}");
        }

        // Значения округлены до 2 знаков после запятой
        Console.WriteLine("\nf2 = x*(ln(x))^2\n");
        for (double x = 1; x <= 3.0; x += 2.0 / 15)
        {
            double f2 = x * Math.Log(x) * Math.Log(x);
            Console.WriteLine($"x = {Math.Round(x, 2)}: {Math.Round(f2, 2)}");
        }
    }
} 