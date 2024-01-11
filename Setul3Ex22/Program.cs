
class Program
{
    /// <summary>
    /// Se dau doi vectori v1 si v2. 
    /// Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi).
    /// Elementele care se repeta vor fi scrise o singura data in rezultat. 
    /// </summary>
    static void Main()
    {
        int[] v1, v2;
        int n, m;
        Console.WriteLine("Introduceti dimensiunea sirului v1");
        n=int.Parse(Console.ReadLine());
        v1 = new int[n];
        Console.WriteLine("Introduceti numerele vectorului v1:");
        for (int i = 0; i < n; i++) 
            v1[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti dimensiunea vectorului v2");
        m=int.Parse(Console.ReadLine());
        v2 = new int[m];
        Console.WriteLine("Introduceti numerele vectorului v2");
        for (int i = 0; i < m; i++)
            v2[i] = int.Parse(Console.ReadLine());

        //Reuniunrea
        List<int> Reuniunea = new();
        for (int i = 0; i < n; i++)
            Reuniunea.Add(v1[i]);
        for (int i = 0; i < m; i++)
            Reuniunea.Add(v2[i]);
        Reuniunea = Reuniunea.Distinct().ToList();
        Console.WriteLine("Reuniunea celor 2 vectori :");
        foreach (int t in Reuniunea)
        {
            Console.Write(t + " ");
        }
        Console.WriteLine();

        //Intersectia
        List<int> intersectia = new();
        for (int i = 0; i < n; i++)
        {
            if (v2.Contains(v1[i]))
                intersectia.Add(v1[i]);
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
        for (int i = 0; i < n; i++)
        {
            if (!v2.Contains(v1[i]))
                Dif1.Add(v1[i]);
        }
        for(int i=0;i<m;i++)
        {
            if (!v1.Contains(v2[i]))
                Dif2.Add(v2[i]);
        }
        Console.WriteLine("Diferenta dintre vectorul v1 si v2 :");
        foreach (var t in Dif1)
            Console.Write(t + " ");
        Console.WriteLine();
        Console.WriteLine("Diferenta dintre vectorul v2 si v1");
        foreach(var t in Dif2)  
            Console.Write(t + " ");
        Console.WriteLine();

    }
}