using System;

class Program
{
    static void Main()
    {
        // Мыши нумеруются с нуля
        string[] input = Console.ReadLine().Split();
        int n = Convert.ToInt32(input[0]); // количество мышей
        int k = Convert.ToInt32(input[1]);
        int z = Convert.ToInt32(input[2]); // номер белой мыши
        int[] mishi = new int[n];
        for (int i = 0; i < n; i++)
            mishi[i] = i;
        if (n == 1)
            Console.WriteLine("0");
        else if (n == 2 && z == 0)
            Console.WriteLine("1");
        else if (n == 2 && z == 1)
            Console.WriteLine("0");

        // Съедаем мышек с конца (начиная с белой) и выводим последнюю - она и будет той, с которой нужно начинать есть мышей
        else
        {
            int pos = z;
            int[] new_mas = RemoveEl(mishi, pos);
            while(new_mas.Length > 1)
            {
                pos = (((pos - k) % new_mas.Length) + new_mas.Length) % new_mas.Length;
                new_mas = RemoveEl(new_mas, pos);
            }
            Console.WriteLine(new_mas[0]);
        }

    }

    
    // Удаление элемента из массива
    static int[] RemoveEl(int[] array, int index)
    {
        int[] newArray = new int[array.Length-1];
        for (int i = 0; i < array.Length; i++)
        {
            if (i < index)
                newArray[i] = array[i];
            else if (i > index)
                newArray[i-1] = array[i];
        }
        return newArray;
    }
}