﻿using System;



class Program
{
    static void Main(string[] args)
    {

        var hour = int.Parse(Console.ReadLine());
        var min = int.Parse(Console.ReadLine());
        min = min + 15;
        if (min >= 60)
        {
            min = min - 60;
            hour = hour + 1;

        }

        if (hour > 23)
        { hour = hour - 24; }

        else if (min >= 60)
        {
            Console.WriteLine(hour + ":" + min);

        }
        if (min < 10)
        {
            Console.WriteLine(hour + ":" + "0" + min);
        }

        else
        {
            Console.WriteLine(hour + ":" + min);
        }
    }
}