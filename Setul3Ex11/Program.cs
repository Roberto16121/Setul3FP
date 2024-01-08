class Program
{
    /// <summary>
    /// Se da un numar natural n.
    /// Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 
    /// </summary>
    static void Main()
    {
        int n;
        Console.WriteLine("introduceti numatul n=");
        n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        for (int i = 0; i < n; i++)
            v[i] = 0;
        v[0] = 1;
        v[1] = 1;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (v[i] == 0)
            {
                for (int j = i; j <= n / i; j++)
                    if (i * j < n)
                        v[i * j] = 1;
            }
        }
        for (int i = 0; i < n; i++)
            if (v[i] == 0)
                Console.Write(i + " ");
    }
}