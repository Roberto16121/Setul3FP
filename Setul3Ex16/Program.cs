using System.Linq;

/// <summary>
/// Se da un vector de n numere naturale.
/// Determinati cel mai mare divizor comun al elementelor vectorului.
/// </summary>
class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti dimensiunea sirului n=");
        n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        Console.WriteLine("Introduceti valorile vectorului :");
        for(int i=0;i<n;i++)
            v[i] = int.Parse(Console.ReadLine());
        Console.WriteLine(GCD(v));
         
    }
    static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }


    static int GCD(int[] integerSet)
    {
        return integerSet.Aggregate(GCD);
    }
}