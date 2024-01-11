class Program
{
    /// <summary>
    /// Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie).
    /// Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 
    /// </summary>
    static void Main()
    {
        string number1, number2;
        Console.WriteLine("Introduceti numarul a =");
        number1 = Console.ReadLine();
        Console.WriteLine("Introduceti numarul b =");
        number2 = Console.ReadLine();
        List<int> a = new();
        List<int> b = new();    
        foreach (var c in number1)
            a.Add(c - '0');
        foreach (var c in number2)
            b.Add(c - '0');
        //Suma
        a.Reverse();
        b.Reverse();
        Console.WriteLine("Suma celor 2 numere este : ");
        SumaNr(a, b);
        Console.WriteLine("Diferenta celor 2 numere este :");
        DiferentaNr(a, b);
        Console.WriteLine("Produsul celor 2 numere este :");
        ProdusNr(a, b);

    }

    static void SumaNr(List<int> a, List<int> b)
    {
        List<int> rez = new();
        int max = Math.Max(a.Count, b.Count);
        int minte = 0;
        for(int i = 0; i < max; i++)
        {
            int cif1 = (i < a.Count) ? a[i] : 0;
            int cif2 = (i < b.Count) ? b[i] : 0;
            int suma = cif1 + cif2 + minte;
            rez.Add(suma % 10);
            minte = suma / 10;
        }
        if(minte > 0)
            rez.Add(minte);
        rez.Reverse();

        PrintList(rez);
    }

    static void DiferentaNr(List<int> a, List<int> b)
    {
        List<int> rez = new();
        int impr = 0;
        if (a.Count < b.Count)
            (a, b) = (b, a);
        else if (a[a.Count-1] < b[b.Count-1])
            (a, b) = (b, a);
        for (int i = 0; i < a.Count || i < b.Count; i++) 
        {
            int cif1 = (i < a.Count) ? a[i] : 0;
            int cif2 = (i < b.Count) ? b[i] : 0;
            int dif = cif1 - cif2 - impr;
            if (dif < 0)
            {
                dif += 10;
                impr = 1;
            }
            else impr = 0;
            rez.Add(dif);
        }
        while(rez.Count > 1 && rez.Last() == 0)
            rez.RemoveAt(rez.Count - 1);
        rez.Reverse();
        PrintList(rez);
    }

    static void ProdusNr(List<int> a, List<int> b)
    {
        List<int> rez = new(new int[a.Count + b.Count]);
        for (int i = 0; i < a.Count; i++)
        {
            int transp = 0;

            for (int j = 0; j < b.Count || transp > 0; j++)
            {
                int produs = rez[i + j] + a[i] * (j < b.Count ? b[j] : 0) + transp;
                rez[i + j] = produs % 10;
                transp = produs / 10;
            }
        }
        while (rez.Count > 1 && rez.Last() == 0)
        {
            rez.RemoveAt(rez.Count - 1);
        }
        rez.Reverse();
        PrintList(rez);
    }

    static void PrintList(List<int> rez)
    {
        foreach (var c in rez) Console.Write(c);
        Console.WriteLine();
    }
}