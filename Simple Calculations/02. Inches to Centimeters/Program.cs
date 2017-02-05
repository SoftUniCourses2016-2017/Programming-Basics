using System;



class Program
{
    static void Main(string[] args)
    {
        Console.Write("Inches = ");
        var inch = double.Parse(Console.ReadLine());
        var cm = inch * 2.54;
        Console.WriteLine(cm);
    }
}
