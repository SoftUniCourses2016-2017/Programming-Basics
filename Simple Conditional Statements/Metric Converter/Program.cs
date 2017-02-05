using System;



class Program
{
    static void Main(string[] args)
    {
        var size = double.Parse(Console.ReadLine());
        string unitFrom = Console.ReadLine();
        string unitTo = Console.ReadLine();
        double factor = 0; // double factor; po default e null

        if (unitFrom == "km")
        {
            size = size / 0.001;
        }
        else if (unitFrom == "cm")
        {
            size = size / 100;
        }
        else if (unitFrom == "mm")
        {
            size = size / 1000;
        }
        else if (unitFrom == "mi")
        {
            size = size / 0.000621371192;
        }
        else if (unitFrom == "in")
        {
            size = size / 39.3700787;
        }
        else if (unitFrom == "yd")
        {
            size = size / 1.0936133;
        }
        else if (unitFrom == "ft")
        {
            size = size / 3.2808399;
        }


        if (unitTo == "ft")
        {
            size = size * 3.2808399;
        }
        else if (unitTo == "cm")
        {
            size = size * 100;
        }
        else if (unitTo == "mm")
        {
            size = size * 1000;
        }
        else if (unitTo == "mi")
        {
            size = size * 0.000621371192;
        }
        else if (unitTo == "in")
        {
            size = size * 39.3700787;
        }
        else if (unitTo == "yd")
        {
            size = size * 1.0936133;
        }
        else if (unitTo == "km")
        {
            size = size * 0.001;
        }
        Console.WriteLine(size + " " + unitTo);
    }
}

