

class Program
{
    /// <summary>
    /// MergeSort
    /// </summary>
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti dimensiunea sirului");
        n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        Console.WriteLine("Introduceti valorile sirului");
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());
        MergeSort(v, 0, n - 1);
        Console.WriteLine("Sirul sortat folosing algoritmul MergeSort este :");
        for (int i = 0; i < n; i++)
            Console.Write(v[i] + " ");
    }

    private static void MergeSort(int[] v, int l, int r)
    {
        if (l < r) 
        {
            int m = l+ (r - l) / 2;

            MergeSort(v, l, m);
            MergeSort(v, m + 1, r);

            Merge(v, l, m, r);
        }
    }

    private static void Merge(int[] v, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;

        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i) 
            L[i] = v[l + i];
        for(j = 0; j < n2; ++j)
            R[j] = v[m + 1 + j];

        i = j = 0;

        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
                v[k++] = L[i++];
            else
                v[k++] = R[j++];
        }

        while (i < n1)
            v[k++] = L[i++];

        while (j < n2)
            v[k++] = R[j++];
    }
}