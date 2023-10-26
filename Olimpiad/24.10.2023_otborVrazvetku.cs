using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32 (Console.ReadLine());
        int[] mas = new int[n+1];
        mas[3] = 1;
        for (int i = 4; i < mas.Length; i++)
            mas[i] = mas[i / 2] + mas[i - i / 2];
        Console.WriteLine(mas[n]);
    }
}