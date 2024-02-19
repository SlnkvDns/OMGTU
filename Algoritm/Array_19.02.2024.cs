using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Элементов в массиве: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());


            Console.WriteLine("Что использовать:\n1)Count\n2)BinSearch\n3)Copy\n4)Find\n5)FindLast\n6)IndexOf\n7)Reverse\n8)Resize\n9)Sort");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(arr.Count(x => x == a));
                    break;
                case "2":
                    Array.Sort(arr);
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(Array.BinarySearch(arr, b));
                    break;
                case "3":
                    int[] newArr = new int[n+2];
                    Array.Copy(arr, newArr, n);
                    foreach (int x in newArr) Console.Write(x + " ");
                    break;
                case "4":
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine(Array.Find(arr, x => x > c));
                    break;
                case "5":
                    int d = int.Parse(Console.ReadLine());
                    Console.WriteLine(Array.FindLast(arr, x => x > d));
                    break;
                case "6":
                    int f = int.Parse(Console.ReadLine());
                    Console.WriteLine(Array.IndexOf(arr, f));
                    break;
                case "7":
                    Array.Reverse(arr);
                    foreach (int x in arr) Console.Write(x + " ");
                    break;
                case "8":
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine(arr.Length);
                    Array.Resize(ref arr, r);
                    Console.WriteLine(arr.Length);
                    break;
                case "9":
                    foreach (int x in arr) Console.Write(x + " ");
                    Console.WriteLine();
                    Array.Sort(arr);
                    foreach (int x in arr) Console.Write(x + " ");
                    break;
            }
        }
    }
}
