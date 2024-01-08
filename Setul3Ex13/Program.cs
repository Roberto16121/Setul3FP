class Program
{
    /// <summary>
    /// Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 
    /// </summary>
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti dimensiunea sirului n=");
        n = int.Parse(Console.ReadLine());
        int[] sir = new int[n];
        Console.WriteLine("Introduceti valorile din sir, una cate una");
        for (int i = 0; i < n; i++)
            sir[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Sirul inainte de sortare :");
        Print(sir, n);
        InsertionSort(sir, n);
        Console.WriteLine("Sirul dupa sortare :");
        Print(sir, n);
    }

    static void InsertionSort(int[] sir, int n)
    {
        for (int i = 0; i < n; i++)
        { 
            int key = sir[i];
            int j = i - 1;
            while(j >= 0 && sir[j] > key)
            {
                sir[j + 1] = sir[j];
                j = j - 1;
            }
            sir[j + 1] = key;
        }
    }

    static void Print(int[] sir, int n)
    {
        for(int i= 0; i < n;i++)
        {
            Console.Write(sir[i] + " ");
        }
        Console.WriteLine();
    }

}