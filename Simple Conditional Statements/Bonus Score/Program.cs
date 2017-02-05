using System;



class Program
{
    static void Main(string[] args)
    {
        string numberAsString = Console.ReadLine();
        int number = int.Parse(numberAsString);
        double bonus = 0;

        if (number <= 100)
        {
            bonus = 5;
        }
        else if (number <= 1000)
        {
            bonus = 0.2 * number;
        }
        else
        {
            bonus = 0.1 * number;
        }
        if (number % 2 == 0)
        {
            bonus = bonus + 1; //ili bonus += 1; ili bonus ++;
        }
        else if (number % 10 == 5)
        {
            bonus = bonus + 2;
        }
        Console.WriteLine("Bonus score: {0}", bonus);
        Console.WriteLine("Total score: {0} ", bonus + number);
    }
}

