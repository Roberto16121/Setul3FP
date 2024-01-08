using System;

class Program
{
    /// <summary>
    /// Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.
    /// Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
    /// Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
    /// </summary>
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti dimeniunea sirului n=");
        n=int.Parse(Console.ReadLine());
        int[] sir = new int[n];
        Console.WriteLine("Introduceti numerele din sir, unul cate unul");
        for(int i = 0; i < n; i++)
            sir[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti numarul de rotiri k=");
        int k = int.Parse(Console.ReadLine());
        //Ex 08
        Console.WriteLine("Sirul inainte de rotire:");
        Print(sir, n);
        Console.WriteLine("Sirul dupa o rotire:");
        Roteste(sir, n, 1);
        Print(sir, n);
        //Ex 09
        Console.WriteLine("Sirul dupa {0} rotiri", k);
        Roteste(sir, n, k - 1);
        Print(sir, n);
    }

    private static void Roteste(int[] sir, int n, int times)
    {
        for (int l = 0; l < times; l++)
        {
            int start = sir[0];
            for (int i = 0; i < n - 1; i++)
            {
                sir[i] = sir[i + 1];
            }
            sir[n - 1] = start;
        }
    }

    static void Print(int[] sir, int n)
    {
        for(int i = 0; i < n; i++) 
        {
            Console.Write(sir[i] + " ");
        }
        Console.WriteLine();
    }
}