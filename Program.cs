// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());
        int[] ints = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} элемент массива: ", i + 1);
            ints[i] = int.Parse(Console.ReadLine());
        }
        int min = 0;
        int a, b;
        double len = (double)ints.Length / 2 - ints.Length / 2;
        int pos = 0;

        if (len != 0)
        {
            a = ints.Length - 1;
        }
        else
        {
            a = ints.Length - 2;
        }

        for (int i = 0; i < a; i = i + 2)
        {
            for (int j = 0; j < a; j = j + 2)
            {
                min = Math.Min(ints[j], ints[j + 2]);
                min = Math.Min(min, ints[j + 2]);
            }

            for (int s = 0; s < ints.Length; s = s + 2)
            {
                if (min == ints[s]) { pos = s; break; }
            }

            if (ints[i] > min)
            {
                b = ints[i];
                ints[i] = min;
                ints[pos] = b;
            }
        }
        Console.WriteLine();
        Console.Write("Получили массив: ");
        for (int k = 0; k < ints.Length; k++)
        {
            Console.Write("{0} ", ints[k]);
        }
        Console.ReadKey();
    }
}
