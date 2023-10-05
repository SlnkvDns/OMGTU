using System;

class Prac
{
    // 1 и 4 задачи. 2 и 3 сделал в классе.
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double minPodpos = double.PositiveInfinity;
        int countZero = 0;
        bool flag = true;
        for (int i = 0; i < n; i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (!(x > 0 && x % 2 == 0 && x % 10 == 6))
                flag = false;
            if (x == 0)           
                countZero++;        
            else if (x != 0)
            {
                if (countZero < minPodpos && countZero != 0)
                    minPodpos = countZero;
                countZero = 0;
            }
        }
        if (countZero != 0 && countZero < minPodpos)
            minPodpos = countZero;
        Console.WriteLine(" ");
        if (minPodpos != double.PositiveInfinity)
            Console.WriteLine(minPodpos);
        else
            Console.WriteLine("0");

        if (flag)
            Console.WriteLine("Да");
        else
            Console.WriteLine("Нет");
    }
}