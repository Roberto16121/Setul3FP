//Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector.
//Cel mai putin semnificativ coeficient este pe pozitia zero in vector.
//Se cere valoarea polinomului intr-un punct x. 


class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti gradul polinomului n =");
        n=int.Parse(Console.ReadLine());
        int[] coef = new int[n+1];
        Console.WriteLine("Introduceti coeficientii in ordinea crescatoare a gradului :");
        for (int i = 0; i <= n; i++)
            coef[i] = int.Parse(Console.ReadLine());
        int x;
        Console.WriteLine("Introduceti valoarea lui x =");
        x = int.Parse(Console.ReadLine());
        long rezultat = coef[0];
        for (int i = 1; i <= n; i++)
        {
            rezultat += ((long)Math.Pow(x, i) * coef[i]);
        }
        Console.WriteLine("Valoare polinomului in punctul {0} este {1}",x,rezultat);

    }
}