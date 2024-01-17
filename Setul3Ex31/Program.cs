class Program
{
    /// <summary>
    /// (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu
    /// m (prin urmare, daca un vector are element majoritate acesta este unui singur).
    /// Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). 
    /// </summary>
    static Dictionary<int, int> elemente = new();
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti dimensiunea vectorului n =");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti valorile vectorului");
        for (int i = 0; i < n; i++) 
        {
            int nr = int.Parse(Console.ReadLine());
            if (elemente.Count == 0)
                elemente.Add(nr, 1);
            else
            {
                int o;
                if(elemente.TryGetValue(nr, out o))
                {
                    elemente[nr]++;
                }
                else elemente.Add(nr, 1);
            }
        }
        for(int i = 0; i < elemente.Count; i++)
        {
            if (elemente.ElementAt(i).Value >= n / 2)
            {
                Console.WriteLine("Elementul majoritate este {0}", elemente.ElementAt(i).Key);
            }
        }
    }
}