class Program
{
    /// <summary>
    /// Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i].
    /// Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 
    /// </summary>
    static void Main()
    {
        int n;
        int[] E, W;
        Console.WriteLine("Introduceti dimensiunea vectorilor n =");
        n = int.Parse(Console.ReadLine());
        E = new int[n];
        W = new int[n];
        Console.WriteLine("Introduceti valorile vectorului E");
        for (int i = 0; i < n; i++)
            E[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti ponderea valorilor vectorului E");
        for (int i = 0; i < n; i++)
            W[i] = int.Parse(Console.ReadLine());
        SortareBicriteriala(E, W, n);
        Console.WriteLine("Vectorul E sortat este :");
        for (int i = 0; i < n; i++)
            Console.Write(E[i] + " ");
        Console.WriteLine();
        Console.WriteLine("Vectorul W sortat este :");
        for (int i = 0; i < n; i++)
            Console.Write(W[i] + " ");
    }

    private static void SortareBicriteriala(int[] E, int[] W, int n)
    {
        for (int i = 0; i < n - 1; i++)
            for (int j = i + 1; j < n; j++)
                if (E[i] > E[j] || (E[i] == E[j] && W[i] < W[j]))
                {
                    (E[i], E[j]) = (E[j], E[i]);
                    (W[i], W[j]) = (W[j], W[i]);
                }
    }
}