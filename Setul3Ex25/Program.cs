class Program
{
    /// <summary>
    /// (Interclasare) Se dau doi vector sortati crescator v1 si v2.
    /// Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2.
    /// Sunt permise elemente duplicate. 
    /// </summary>
    static void Main()
    {
        int n, m;
        int[] v1, v2;
        Console.WriteLine("Introduceti dimensiunea sirului v1");
        n=int.Parse(Console.ReadLine());
        v1 = new int[n];
        Console.WriteLine("Introduceti valorile vectorului v1:");
        for(int i = 0; i < n; i++)
            v1[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti dimensiunea sirului v2");
        m = int.Parse(Console.ReadLine());
        v2 = new int[m];
        Console.WriteLine("Introduceti valorile vectorului v2:");
        for (int i = 0; i < m; i++)
            v2[i] = int.Parse(Console.ReadLine());
        List<int> finalVector = new();
        int index1 = 0, index2 = 0;
        while(index1 < n || index2 < m)
        {
            if (index1 < n && index2 < m)
            {
                if (v1[index1] >= v2[index2])
                {
                    finalVector.Add(v2[index2]);
                    index2++;
                }
                else
                {
                    finalVector.Add(v1[index1]);
                    index1++;
                }
            }
            else if(index1 < n)
            {
                finalVector.Add(v1[index1]);
                index1++;
            }
            else
            {
                finalVector.Add(v2[index2]);
                index2++;
            }
        }
        Console.WriteLine("Rezultatul intercalari celor 2 vectori este :");
        foreach(int t in finalVector)
            Console.Write(t + " ");
        Console.WriteLine();




    }

}