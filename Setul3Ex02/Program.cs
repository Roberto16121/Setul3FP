using System;

class Program
{
    static void Main()
    {
        string text;
        Console.WriteLine("Introduceti un vector de numere, de forma x y z:");
        text = Console.ReadLine();
        int k;
        Console.WriteLine("Introduceti un numar k=");
        k = int.Parse(Console.ReadLine());
        string[] numbers = text.Split(' ');
        int[] sir = new int[numbers.Length];
        int index = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            sir[i] = int.Parse(numbers[i]);
            if (sir[i] == k)
            {
                index = i;
                break;
            }
        }
        Console.WriteLine(index != -1 ? $"Numarul {k} apare pe pozitia {index}" : $"Numarul {k} nu apare in sir");
    }
}