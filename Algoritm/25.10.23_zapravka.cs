using System;

class Program
{
    static void Main()
    {
        // Положение первого города = 1
        Console.Write("Количество городов: ");
        int k = Convert.ToInt32 (Console.ReadLine());
        int[] rast = new int[k-1];
        Console.Write("p: ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Расстояния: ");
        for (int i = 0; i < k-1; i++)
        {
            rast[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] sb = new int[k];
        for (int i = 0; i < k; i++)
            for (int j = 0; j < i; j++)
                sb[i] += SumSreza(rast, j, i);


        int[] sa = new int[k];
        for (int i = 0; i < k-1; i++)
            for (int j = i+1; j < k; j++)
                sa[i] += SumSreza(rast, i, j);

        int[] s = new int[k - 1];
        for (int i = 0; i < k-1; i++)
        {
            if (rast[i] < 2 * p)
                s[i] = 100000000;
            else
            {
                int l, c;
                if (i < (k-1) / 2)
                {
                    l = p;
                    c = rast[i] - l;
                }
                else
                {
                    c = p;
                    l = rast[i] - c;
                }
                s[i] = sb[i] + sa[i + 1] + (i + 1) * c + (k - 1 - i) * l;
            }
        }
        if (s.Min() == 100000000)
            Console.WriteLine("Нельзя поставить заправку");
        else
        {
            int min = s[0];
            int ind = 0;
            int zapravka;
            for (int i = 1; i < s.Length; i++)
                if (s[i] < min)
                {
                    ind = i;
                    min = s[i];
                }

            if (ind < (k - 1) / 2)
                zapravka = SumSreza(rast, 0, ind+1) - p + 1;
            else
                zapravka = SumSreza(rast, 0, ind) + p + 1;

            Console.WriteLine($"Минимальная сумма расстояний от каждого города до заправки: {s.Min()}");
            // Положение первого города = 1
            Console.WriteLine($"Положение заправки: {zapravka}");
        }
    }

    // Функция считает сумму элементов среза массива
    static int SumSreza(int[] array, int n, int m)
    {
        int sum = 0;
        for (int i = n; i < m; i++)
            sum += array[i];
        return sum;
    }
}