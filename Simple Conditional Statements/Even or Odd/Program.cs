using System;



class Program
{
    static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}

