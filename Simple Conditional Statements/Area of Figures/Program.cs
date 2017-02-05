using System;



class Program
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine();

        if (figure == "square")
        {
            var a = double.Parse(Console.ReadLine());
            double area = a * a;
            Console.WriteLine(Math.Round(area, 3));
        }
        else if (figure == "rectangle")
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            double area = a * b;
            Console.WriteLine(Math.Round(area, 3));

        }
        else if (figure == "circle")
        {
            var r = double.Parse(Console.ReadLine());
            double area = r * r * Math.PI;
            Console.WriteLine(Math.Round(area, 3));
        }
        if (figure == "triangle")
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            double area = (a * 0.5) * h;
            Console.WriteLine(Math.Round(area, 3));
        }

    }
}

