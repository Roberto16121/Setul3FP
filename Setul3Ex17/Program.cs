
using System.Text;

class Program
{
    //Se da un numar n in baza 10 si un numar b. 1 < b < 17.
    //Sa se converteasca si sa se afiseze numarul n in baza b.   
    static string cifre = "0123456789ABCDEF";
    static void Main()
    {
        string? read;
        Console.WriteLine("Introduceti numatul in baza 10 :");
        read = Console.ReadLine();
        bool dot = false;
        if (read.Contains('.'))
            dot = true; 
        Console.WriteLine("Introduceti baza in care vreti sa il convertiti (2-16) : ");
        int baza;
        while((baza = int.Parse(Console.ReadLine())) is > 16 or < 2)
        {
            Console.WriteLine("Introduceti baza din intervalul 2-16 :");
        }
        Console.WriteLine(Conversie(read, dot, baza));
    }
    static string Conversie(string number, bool dot, int toBase)
    {
        StringBuilder sb = new StringBuilder();
        if(dot)
        {
            string[] splited = number.Split('.');
            string whole = ConvertToWhole(splited[0], toBase);
            string fraction = ConvertFractionPart(splited[1], toBase);
            sb.Append(whole);
            sb.Append('.');
            sb.Append(fraction);
        }
        else
        {
            string whole = ConvertToWhole(number, toBase);
            sb.Append(whole);
        }


        return sb.ToString();
    }

    static string ConvertToWhole(string whole, int toBase)
    {
        long number = long.Parse(whole);
        string toRet = "";
        while (number != 0)
        {
            long rest = number % toBase;
            number /= toBase;
            toRet = cifre[(int)rest] + toRet;
        }
        return toRet;
    }

    static string ConvertFractionPart(string fraction, int toBase)
    {
        decimal number = decimal.Parse(fraction);
        number /= (decimal)Math.Pow(10, fraction.Length);
        string toRet = "";
        List<decimal> decimals = new(); // it stores the decimals that we already encountered
        bool isRepeating = false;
        int decimalPoints = 0, limit = 8; //limit is the maximum number of decimal points we allow
        while (!isRepeating && decimalPoints < limit)
        {
            number *= toBase;
            int nr = (int)number;
            number -= nr;
            if (decimals.Contains(number))
            {
                isRepeating = true;
                break;
            }
            decimals.Add(number);
            toRet += cifre[nr];
            if (number == 0)
                break;
            decimalPoints++;
        }
        //if a number is repeating we add the brackets
        if (isRepeating)
        {
            decimals.IndexOf(number);
            toRet = string.Concat(toRet.AsSpan(0, decimals.IndexOf(number)), "(", toRet.AsSpan(decimals.IndexOf(number)), ")");
        }

        return toRet;
    }
}