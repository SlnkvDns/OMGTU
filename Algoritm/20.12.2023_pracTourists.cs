using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Всё расстояние");
        int rast = int.Parse(Console.ReadLine());
        Console.WriteLine("Количество пунктов: ");
        int kol = int.Parse(Console.ReadLine());
        Console.WriteLine("Скорость: ");
        int speed = int.Parse(Console.ReadLine());
        float[] masRast = new float[kol + 3];
        masRast[masRast.Length - 1] = 1000000000000000000;
        masRast[masRast.Length - 2] = rast;
        int[] masPos = new int[kol + 2];
        Console.WriteLine("Время восхода: ");
        string[] vosh = Console.ReadLine().Split();
        float voshod = float.Parse(vosh[0]) + float.Parse(vosh[1])/60;
        Console.WriteLine("Время заката: ");
        string[] zak = Console.ReadLine().Split();
        float zakat = float.Parse(zak[0]) + float.Parse(zak[1]) / 60;
        Console.WriteLine("Расстояние от начала до каждого пункта: ");
        for (int i = 1; i < masRast.Length - 2; i++) masRast[i] = int.Parse(Console.ReadLine());
        float maxProh = (zakat - voshod) * speed, curRast = 0;
        int countDays = 0;
        float prev = 0;
        for (int i = 1; i < masRast.Length; i++)
        {
            if (maxProh < masRast[i]) break;
            else
            {
                for (int j = i + 1; j < masRast.Length; j++)
                {
                    if (maxProh >= masRast[j])
                    {
                        i = j;
                    }
                }
                countDays++;
                maxProh += masRast[i] - prev;
                prev = masRast[i];
                masPos[i - 1] = 1;
                
            }

        }
        if (masPos[masPos.Length - 2] == 1)
        {
            Console.Write($"Группа дойдёт до конца за количество дней: {countDays}, посетив пункты с номерми: ");
            for (int i = 0; i < masPos.Length - 2; i++)
            {
                if (masPos[i] == 1) Console.Write(i + 1 + " ");
            }
        }
        else Console.WriteLine("Группа не может дойти до конца");
    }
}