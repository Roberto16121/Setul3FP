using System;

class Program
{
    /// <summary>
    /// Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
    /// </summary>
    static void Main()
    {
        string text;
        Console.WriteLine("Introduceti sirul de numere, sub forma x y z :");
        text = Console.ReadLine();
        string[] numbers = text.Split(' ');
        int[] sir = new int[numbers.Length];
        int min = int.MaxValue;
        int max = int.MinValue;
        int nrMin = 0;
        int nrMax = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sir[i] = int.Parse(numbers[i]);
            if (sir[i] < min)
            {
                min = sir[i];
                nrMin = 1;
            }
            else if (sir[i] == min)
            {
                nrMin++;
            }
            if (sir[i] > max)
            {
                max = sir[i];
                nrMax = 1;
            }
            else if (sir[i] == max)
            {
                nrMax++;
            }
        }
        Console.WriteLine($"Numarul minim este {min} si apare de {nrMin}");
        Console.WriteLine($"Numarul maxim este {max} si apare de {nrMax}");

    }
}