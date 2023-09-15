using System;
class Lab
{
    static void Main()
    {
        // Блок 1 (10 чисел)
        double max = Double.NegativeInfinity;
        int count_positive = 0, count_negative = 0, sum_positive = 0, sum_kr3 = 0;
        for (int i = 0; i < 10; i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > max)
                max = x;
            if (x > 0)
            {
                count_positive++;
                sum_positive += x;
            }
            if (x < 0)
                count_negative++;
            if (x % 3 == 0)
                sum_kr3 += x;
                   
        }
        Console.WriteLine($"Максимальное значение: {max}");
        Console.WriteLine($"Среднее арифметическое положительных: {sum_positive*1.0/count_positive}");
        Console.WriteLine($"Количество отрицательных: {count_negative}");
        Console.WriteLine($"Сумма элементов, кратных трём: {sum_kr3}");


        // Блок 2 (n чисел)
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int prev = Convert.ToInt32(Console.ReadLine());
        int count_more_prev = 0, count_less_prevs = 0, count_pairs = 0;
        double min_prev = Double.PositiveInfinity;
        for (int i = 0; i < (n-1); i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > prev)
                count_more_prev++;
            if (prev < min_prev)
                min_prev = prev;
            if (x < min_prev)
                count_less_prevs++;
            if (prev + x > 0)
                count_pairs++;
            prev = x;
        }
        Console.WriteLine($"Кол-во элементов, значение которых больше предшествующего элемента: {count_more_prev}");
        Console.WriteLine($"Кол-во элементов, значение которых меньше предшествующих элементов: {count_less_prevs}");
        Console.WriteLine($"Кол-во пар, значение суммы которых положительно: {count_pairs}");
    }
}

