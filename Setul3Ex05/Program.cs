using System;

class Program
{
    /// <summary>
    /// Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
    /// Se cere sa se insereze valoarea e in vector pe pozitia k.
    /// Primul element al vectorului se considera pe pozitia zero. 
    /// </summary>
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti numarul de elemente din vector:");
        n = int.Parse(Console.ReadLine());
        int[] sir = new int[n+1];
        Console.WriteLine("Introduceti elementele vectorului");
        for (int i = 0; i < n; i++)
            sir[i] = int.Parse(Console.ReadLine());
        int e;
        Console.WriteLine("Introduceti valoarea e:");
        e = int.Parse(Console.ReadLine());
        int k;
        Console.WriteLine("Introduceti pozitia k:");
        k = int.Parse(Console.ReadLine());
       
        int oldvalue = sir[k];
        for (int i = k; i < n; i++) 
        {
            sir[i] = e;
            e = oldvalue;
            oldvalue = sir[i + 1];
        }
        sir[n] = e;
        for(int i=0;i<=n;i++)
        {
            Console.Write($"{sir[i]} ");
        }
    }
}
