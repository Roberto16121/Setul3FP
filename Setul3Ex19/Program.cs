class Program
{
    /// <summary>
    /// Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta).
    /// Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori.
    /// (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 
    /// </summary>
    static void Main()
    {
        int DimS, DimP;
        int[] sirS, sirP;
        Console.WriteLine("Introduceti lungimea vectorului s(vectorul in care se cauta) :");
        DimS = int.Parse(Console.ReadLine());
        sirS = new int[DimS];
        Console.WriteLine("Introduceti valorile vectorului s");
        for(int i = 0; i < DimS; i++)
            sirS[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti lungimea vectorului p(vectorul care se cauta)");
        DimP = int.Parse(Console.ReadLine());
        sirP = new int[DimP];
        Console.WriteLine("Introduceti valorile vectorului p");
        for(int i=0; i < DimP; i++)
            sirP[i] = int.Parse(Console.ReadLine());
        int nr = 0;
        for (int i = 0; i < DimS; i++) 
        {
            int[] partOfS = new int[DimP];
            if (i + DimP > DimS)
                break;
            Array.Copy(sirS, i, partOfS, 0, DimP);
            bool Same = true;
            for(int j=0;j< DimP; j++)
            {
                if (partOfS[j] != sirP[j])
                { Same = false; break; }
            }
            if (Same)
                nr++;
        }
        Console.WriteLine("Sirul p apare de {0} ori in sirul s", nr);
    }
}