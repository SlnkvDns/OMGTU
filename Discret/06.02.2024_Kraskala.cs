using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dorogi = new Dictionary<string, int>();
            const int n = 1000000;
            int[,] graf = { {n, 4, n, 3, 6, 1, n}, {4, n, 2, 3, 7, 6, 1 }, {n, 2, n, n, 4, n, 2 }, {3, 3, n, n, 1, 5, 3 }, {6, 7, 4, 1, n, 3, 6}, {1, 6, n, 5, 3, n, 7 }, {n, 1, 2, 3, 6, 7, n } };
            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j < 8; j++)
                {
                    if (graf[i-1, j-1] != n && !dorogi.ContainsKey(Convert.ToString(j) + Convert.ToString(i)))
                    {
                        dorogi.Add(Convert.ToString(i) + Convert.ToString(j), graf[i-1, j-1]);
                    }
                }
            }
            dorogi = dorogi.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (string a in dorogi.Keys) Console.Write(dorogi[a] + " ");
        } 
    }
}
