using System;

class Volleyball
{
    static void Main()
    {

        string year = Console.ReadLine();
        double p = int.Parse(Console.ReadLine());
        double h = int.Parse(Console.ReadLine());

        double result = p * 2 / 3 + (48 - h) * 3 / 4 + h;
        if (year == "leap")
        {
            result += (result * 15) / 100;
        }


        Console.WriteLine((int)result);
    }
}