
class Program
{
    /// <summary>
    /// Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2.
    /// Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare.
    /// Siragurile de margele se pot roti atunci cand le suprapunem. 
    /// </summary>
    static void Main()
    {
        int n;
        int[] s1, s2;
        Console.WriteLine("Introduceti dimensiunea siraguriloe de margele");
        n = int.Parse(Console.ReadLine());
        s1 = new int[n];
        Console.WriteLine("Introduceti tipul de margele (0-alba, 1-neagra)");
        for(int i = 0; i < n; i++)
            s1[i]= int.Parse(Console.ReadLine());
        s2 = new int[n];
        Console.WriteLine("Introduceti tipul de margele (0-alba, 1-neagra)");
        for (int i = 0; i < n; i++)
            s2[i] = int.Parse(Console.ReadLine());

        Solve(s1,s2,n);
    }

    static void MoveLeft(int[] sir, int n)
    {
        int start = sir[0];
        for(int i = 1; i < n; i++)
            sir[i - 1] = sir[i];
        sir[n - 1] = start;
    }

    static int NrSuprapuneri(int[] s1, int[] s2, int n)
    {
        int nr = 0;
        for (int i = 0; i < n; i++)
            if (s1[i] == s2[i])
                nr++;
        return nr;
    }

    private static void Solve(int[] s1, int[] s2, int n)
    {
        int suprapuneri = 0;
        int nr = 0;
        int maxim = 0;
        while(nr <= n)
        {
            suprapuneri = NrSuprapuneri(s1, s2, n);
            MoveLeft(s1, n);
            nr++;
            if (maxim < suprapuneri)
                maxim = suprapuneri;
        }

        Console.WriteLine("Numarul maxim de suprapuneri care pot exista este {0}", maxim);
    }
}