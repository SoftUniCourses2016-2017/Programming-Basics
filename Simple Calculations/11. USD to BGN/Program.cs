using System;



class Program
{
    static void Main(string[] args)
    {
        var USD = double.Parse(Console.ReadLine());
        var BGN = USD * 1.79549;
        Console.WriteLine("{0}", Math.Round(BGN, 2));
    }
}

