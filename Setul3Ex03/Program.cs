using System;

class Program
{
    /// <summary>
    /// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
    /// Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 
    /// </summary>
    static void Main()
    {
        string text;
        Console.WriteLine("Introduceti un vector de numere, de forma x y z:");
        text = Console.ReadLine();
        int nr = 0;
        string[] numbers = text.Split(' ');
        int[] sir = new int[numbers.Length];
        int min = int.MaxValue;
        int max = int.MinValue;
        int pozMin = 0;
        int pozMax = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sir[i] = int.Parse(numbers[i]);
            if (sir[i] < min)
            {
                nr++;
                min = sir[i];
                pozMin = i;
            }
            else if (sir[i] > max)
            {
                nr += 2;
                max = sir[i];
                pozMax = i;
            }
            else nr += 2;
        }
        Console.WriteLine(nr);

    }

}