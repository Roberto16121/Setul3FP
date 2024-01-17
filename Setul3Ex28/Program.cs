using System.Collections.Concurrent;

class Program
{
    //QuickSort
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti dimensiunea vectorului");
        n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        Console.WriteLine("Introduceti valorile vectorului");
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());
        QuickSort(v, 0, n - 1);
        Console.WriteLine("Sirul sortat folosing algoritmul QuickSort este :");
        for (int i = 0; i < n; i++)
            Console.Write(v[i] + " ");  
    }
    static void QuickSort(int[] v, int low, int high)
    {
        if(low < high)
        {
            int pi = Partition(v, low, high);

            QuickSort(v, low, pi - 1);
            QuickSort(v, pi + 1, high);
        }
    }

    private static int Partition(int[] v, int low, int high)
    {
        int pivot = v[high];

        int i = low - 1;
        for(int j=low;j<=high-1;j++)
        {
            if (v[j] < pivot)
            {
                i++;
                (v[i], v[j]) = (v[j], v[i]);
            }
        }
        (v[i + 1], v[high]) = (v[high], v[i + 1]);
        return i + 1;
    }
}