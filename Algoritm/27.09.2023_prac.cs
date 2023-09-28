using System;
class Prac
{
    static void Main()
    {
        int s = 0;
        double ost11 = double.PositiveInfinity, ost12 = double.PositiveInfinity, ost21 = double.PositiveInfinity, ost22 = double.PositiveInfinity;
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            // Массив используется только для считывания двух чисел с одной строки через пробел ( не ругайте, пожалуйста )
            string[] num = Console.ReadLine().Split(' ');
            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);

            // Выбираем из пары максимальный элемент и прибавляем к сумме
            if (a >= b)
                s += a;
            else
                s += b;

            // Ищем 2 минимальные разности между элементами пары с остатком от деления на 3, равным единице (минимальная разность получается = ost11)
            if (Math.Abs(a-b)%3 == 1)
            {
                if (Math.Abs(a-b) <= ost11)
                {
                    ost12 = ost11;
                    ost11 = Math.Abs(a-b);
                }
                else if (Math.Abs(a-b) <= ost12)
                    ost12 = Math.Abs(a-b);
            }

            // Ищем 2 минимальные разности между элементами пары с остатком от деления на 3, равным двойке (минимальная разность получается = ost21)
            else if (Math.Abs(a-b)%3 == 2)
            {
                if (Math.Abs(a - b) <= ost21)
                {                        
                    ost22 = ost21;
                    ost21 = Math.Abs(a - b);
                }
                else if (Math.Abs(a - b) <= ost22)
                    ost22 = Math.Abs(a - b);
            }
        }

        // Проверяем, что меньше: сумма минимальных разностей с остатком 1 или минимальная разность с остатком 2
        double minOst2;
        if (ost21 <= (ost11 + ost12))
            minOst2 = ost21;
        else
            minOst2 = ost11 + ost12;

        // Проверяем, что меньше: сумма минимальных разностей с остатком 2 или минимальная разность с остатком 1
        double minOst1;
        if (ost11 <= (ost21 + ost22))
            minOst1 = ost11;
        else
            minOst1 = ost21 + ost22;

        // Если накопившаяся сумма делится на 3, выводим её
        if (s % 3 == 0)
            Console.WriteLine(s);

        // Если у суммы получился остаток 1, то вычитаем min( минимальная разность с остатком 1 ; сумма двух минимальных разностей с остатком 2 )
        else if (s % 3 == 1)
        {
            if (s - minOst1 >= 0)
                Console.WriteLine(s - minOst1);
            else
                Console.WriteLine("Такой суммы нет");
        }

        // Если у суммы получился остаток 2, то вычитаем min( минимальная разность с остатком 2 ; сумма двух минимальных разностей с остатком 1 )
        else if (s % 3 == 2)
        {
            if (s - minOst2 >= 0)
                Console.WriteLine(s - minOst2);
            else
                Console.WriteLine("Такой суммы нет");
        }
    }
}
