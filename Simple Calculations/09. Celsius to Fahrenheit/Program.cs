using System;



class Program
{
    static void Main(string[] args)
    {
        double celsius = double.Parse(Console.ReadLine());
        double farenheit = (celsius * 1.800) + 32.00;
        Console.WriteLine("{0}", Math.Round(farenheit, 2));
    }
}

