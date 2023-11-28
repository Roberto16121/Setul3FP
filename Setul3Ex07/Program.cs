using System;
using System.Numerics;
using System.Xml.Linq;
class Program
{
    /// <summary>
    /// Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
    /// Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
    /// </summary>
    static void Main()
    {
        int n;
        Console.Write("Introduceti numarul de elemente din vector ");
        n = int.Parse(Console.ReadLine());
        int[] sir = new int[n];
        Console.WriteLine("Introduceti elementele vectorului");
        for(int i=0;i<n;i++)
            sir[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n/2; i++)
        {
            (sir[i], sir[n - i - 1]) = (sir[n - i - 1], sir[i]);
        }
        for (int i = 0; i < n; i++)
            Console.Write(sir[i] + " ");

    }
}
