﻿using System;



class Program
{
    static void Main(string[] args)
    {
        var r = double.Parse(Console.ReadLine());
        var area = Math.PI * r * r;
        var perimeter = 2 * Math.PI * r;
        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}

