using System;

class Program
{
    static void Main()
    {
        int whiteMice = int.Parse(Console.ReadLine());
        int greyMice = int.Parse(Console.ReadLine());
        int ostWhite = int.Parse(Console.ReadLine());
        int ostGrey = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int survivingMice = ostGrey + ostWhite;
        int deadMice = whiteMice + greyMice - survivingMice;
        if (greyMice == 1 && ostGrey == 1 && step == whiteMice + greyMice)
            Console.WriteLine("Такая рассадка невозомжна");
        else
        {
            int[] mice = new int[whiteMice + greyMice];
            int count = 0;
            int i = 0;
            int countKills = 0;
            while (countKills < deadMice)
            {
                i++;
                if (mice[((i % mice.Length) + mice.Length) % mice.Length] != 1) count++;
                if (count == step)
                {
                    mice[((i % mice.Length) + mice.Length) % mice.Length] = 1;
                    count = 0;
                    countKills++;
                }
            }

            string[] mice2 = new string[whiteMice + greyMice];
            int countW1 = 0, countG1 = 0, countW2 = 0, countG2 = 0;
            for (int j = 0; j < mice.Length; j++)
            {
                if (mice[j] != 1 && countG1 < ostGrey)
                {
                    mice2[j] = "С";
                    countG1++;
                }
                else if (mice[j] != 1 && countW1 < ostWhite)
                {
                    mice2[j] = "Б";
                    countW1++;
                }
                else if (mice[j] == 1 && countG2 < greyMice - ostGrey)
                {
                    mice2[j] = "С";
                    countG2++;
                }
                else if (mice[j] == 1 && countW2 < whiteMice - ostWhite)
                {
                    mice2[j] = "Б";
                    countW2++;
                }
            }
            foreach (string el in mice2) Console.Write(el + " ");
            Console.WriteLine();
        }
    }
} 