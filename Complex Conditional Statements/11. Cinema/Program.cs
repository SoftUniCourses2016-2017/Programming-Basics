using System;

class Program
{
    static void Main()
    {
        string movieType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int seats = rows * cols;
        decimal ticketPrice = 0;

        if (movieType == "Premiere")
        {
            ticketPrice = 12.00m;
            Console.WriteLine("{0:f2} leva", seats * ticketPrice);
        }
        else if (movieType == "Normal")
        {
            ticketPrice = 7.50m;
            Console.WriteLine("{0:f2} leva", seats * ticketPrice);
        }
        else
        {
            ticketPrice = 5.00m;
            Console.WriteLine("{0:f2} leva", seats * ticketPrice);

        }
    }
}

