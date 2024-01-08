/// <summary>
/// Sortare selectie. Implementati algoritmul de sortare (Selection Sort). 
/// Sortare prin insertie. Implementati algoritmul de sortare (Insertion Sort). 
/// </summary>
class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti dimensiunea vectorului n=");
        n=int.Parse(Console.ReadLine());
        int[] v = new int[n];
        Console.WriteLine("Introduceti valorile din vector :");
        for(int i= 0; i < n;i++)
            v[i] = int.Parse(Console.ReadLine());
        //Console.WriteLine("SelectionSort");
        //SelectionSort(v);


        Console.WriteLine("InsertionSort");
        InsertionSort(v);

    }

    static void SelectionSort(int[] arr)
    {
        for(int i=0;i<arr.Length;i++)
        {
            int minIndex = i;
            for(int j=i+1;j<arr.Length;j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }
    static void InsertionSort(int[] arr)
    {
        for(int i=1;i<arr.Length;i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }

}