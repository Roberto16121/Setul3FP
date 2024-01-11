class Program
{
    /// <summary>
    /// Aceleasi cerinte ca si la problema anterioara dar de data asta elementele
    /// sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
    /// </summary>
    static void Main()
    {
        int[] v1, v2;
        int n, m;
        Console.WriteLine("Introduceti dimensiunea sirului v1");
        n = int.Parse(Console.ReadLine());
        v1 = new int[101];
        Console.WriteLine("Introduceti numerele vectorului v1: (0, 100)");
        for (int i = 0; i < n; i++)
        {
            int nr = int.Parse(Console.ReadLine());
            if(nr > 100)
                throw new Exception("Number is over 100");
            v1[nr] = 1;
        }
        Console.WriteLine("Introduceti dimensiunea vectorului v2");
        m = int.Parse(Console.ReadLine());
        v2 = new int[101];
        Console.WriteLine("Introduceti numerele vectorului v2 : (0,100");
        for (int i = 0; i < m; i++)
        {
            int nr = int.Parse(Console.ReadLine());
            if (nr > 100)
                throw new Exception("Number is over 100");
            v2[nr] = 1;
        }

        //Reuniunrea
        List<int> Reuniunea = new();
        for (int i = 0; i < 100; i++)
            if (v1[i] != 0)
                Reuniunea.Add(i);
        for (int i = 0; i < 100; i++)
            if (v2[i] != 0)
                Reuniunea.Add(i);
        Reuniunea = Reuniunea.Distinct().ToList();
        Console.WriteLine("Reuniunea celor 2 vectori :");
        foreach (int t in Reuniunea)
        {
            Console.Write(t + " ");
        }
        Console.WriteLine();

        //Intersectia
        List<int> intersectia = new();
        for (int i = 0; i < 100; i++)
        {
            if (v2[i] == 1 && v1[i] == 1)
                intersectia.Add(i);
        }
        intersectia = intersectia.Distinct().ToList();
        Console.WriteLine("Intersectia celor 2 vectori :");
        foreach (int t in intersectia)
        {
            Console.Write(t + " ");
        }
        Console.WriteLine();

        //Diferentele
        List<int> Dif1 = new();
        List<int> Dif2 = new();
        for (int i = 0; i < 100; i++)
        {
            if (v1[i] == 1 && v2[i] != 1)
                Dif1.Add(i);
        }
        for (int i = 0; i < 100; i++)
        {
            if (v1[i] != 1 && v2[i] == 1)
                Dif2.Add(i);
        }
        Console.WriteLine("Diferenta dintre vectorul v1 si v2 :");
        foreach (var t in Dif1)
            Console.Write(t + " ");
        Console.WriteLine();
        Console.WriteLine("Diferenta dintre vectorul v2 si v1");
        foreach (var t in Dif2)
            Console.Write(t + " ");
        Console.WriteLine();
    }
}