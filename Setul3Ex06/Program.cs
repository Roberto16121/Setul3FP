using System;

class Program
{
    /// <summary>
    /// Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k.
    /// Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
    /// </summary>
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti de elemente din vector ");
        n = int.Parse(Console.ReadLine());
        int[] sir = new int[n];
        Console.WriteLine("Introduceti elementele vectorului");
        for(int i=0;i<n;i++)
            sir[i] = int.Parse(Console.ReadLine());
        int k;
        Console.WriteLine("Introduceti o pozitie k = ");
        k = int.Parse(Console.ReadLine());
        while(k > n)
        {
            Console.WriteLine("Introduceti o pozitie mai mica decat {0}", n);
            k = int.Parse(Console.ReadLine());
        }
        for(int i=k;i<n-1;i++)
            sir[i] = sir[i + 1];
        n--;
        for(int i=0;i<n;i++)
            Console.Write($"{sir[i]} ");
        
    }
}