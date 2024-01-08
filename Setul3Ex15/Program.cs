/// <summary>
/// Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 
/// </summary>
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti n=");
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        Console.WriteLine("Introduceti elementele vectorului : ");
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());
        for(int i=0;i< n;i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (v[i] == v[j])
                {
                    for(int k=j; k < n-1; k++)
                    {
                        v[k] = v[k+1];

                    }
                    n--;
                }
            }
        }
        for(int i=0;i<n ; i++)
            Console.Write(v[i] + " ");

    }
}