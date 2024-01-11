class Program
{
    /// <summary>
    /// e dau doi vectori.
    /// Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 
    /// </summary>
    static void Main()
    {
        string s1, s2;
        Console.WriteLine("Introduceti primul vector :");
        s1 = Console.ReadLine();
        Console.WriteLine("Introduceti al doilea vector :");
        s2 = Console.ReadLine();

        if (s1.Length > s2.Length)
            (s1, s2) = (s2, s1);
        Console.WriteLine("Ordinea lexicografica");
        bool found = false;
        for (int i = 0;i<s1.Length && !found;i++)
        {
            if (s1[i] > s2[i])
            {
                Console.WriteLine(s2);
                Console.WriteLine(s1);
                found = true;
            }
        }
        if(!found)
        {
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}