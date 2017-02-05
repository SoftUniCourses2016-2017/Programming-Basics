using System;



class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = a * h / 2;
        Console.WriteLine("{0}", Math.Round(area, 2));
    }
}

