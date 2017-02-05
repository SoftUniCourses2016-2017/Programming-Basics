using System;



class Program
{
    static void Main(string[] args)
    {
        double radians = double.Parse(Console.ReadLine());
        var degrees = radians * 180 / Math.PI;
        Console.WriteLine("{0}", Math.Round(degrees));
    }
}

