class Program
{
    /// <summary>
    /// Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare.
    /// Se cere sa se determine pozitia unui element dat k.
    /// Daca elementul nu se gaseste in vector rezultatul va fi -1. 
    /// </summary>
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti dimensiunea sirului n=");
        n=int.Parse(Console.ReadLine());
        int[] sir = new int[n];
        Console.WriteLine("Introduceti un sir sortat in orine crescatoare de {0} numere", n);
        for(int i = 0; i < n; i++) 
            sir[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti un numar");
        int numarCautat = int.Parse(Console.ReadLine());
        int rezultat = CautareBinara(sir, 0, n-1, numarCautat);
        Console.WriteLine(rezultat != -1 ? $"Numarul {numarCautat} se afla pe positia {rezultat}" : 
            $"Numarul {numarCautat} nu se aflta in sir");
    }
    static int CautareBinara(int[] sir, int start, int end, int nr)
    {
        if (start > end)
            return -1;
        int mid = (end - start) / 2;
        if (sir[mid] == nr)
            return mid;
        else if (sir[mid] > nr)
            return CautareBinara(sir, mid + 1, end, nr);
        else return CautareBinara(sir, start, mid - 1, nr);

    }
}