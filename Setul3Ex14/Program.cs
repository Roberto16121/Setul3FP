/// <summary>
/// Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit.
/// (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient
/// - se va face o singura parcugere a vectorului). 
/// </summary>
class Program
{
    static void SolveInOne(int[] sir, int n)
    {
        int nonZero = 0;

        for (int i = 0; i < n; i++)
        {
            if (sir[i] != 0)
            {
                int temp = sir[i];
                sir[i] = sir[nonZero];
                sir[nonZero] = temp;
                nonZero++;
            }
        }
    }


    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti dimeniunea vectorului, n=");
        n=int.Parse(Console.ReadLine());
        int[] v = new int[n];
        Console.WriteLine("Introduceti valorile vectorului :");
        for(int i=0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());
        SolveInOne(v, n);
        Print(v, n);
    }
    static void Print(int[] sir, int n)
    {
        for (int i = 0; i < n; i++)
            Console.Write(sir[i] + " ");
        Console.WriteLine();
    }
}