class Program
{
    /// <summary>
    /// Se da un vector si un index in vectorul respectiv.
    /// Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. 
    /// </summary>
    static void Main()
    {
        int n, index;
        int[] v1;
        Console.WriteLine("Introduceti dimeniunea vectorului n =");
        n=int.Parse(Console.ReadLine());
        v1 = new int[n];
        Console.WriteLine("Introduceti valorile vectorului");
        for(int i = 0; i < n; i++)
            v1[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti un index :");
        index = int.Parse(Console.ReadLine());
        if (index >= n || index < 0)
            throw new Exception("Indexul este inafara vectorului");
        Array.Sort(v1);
        Console.WriteLine("Numarul de la indexul {0} din vectorul sortat este {1}", index, v1[index]);
    }
}