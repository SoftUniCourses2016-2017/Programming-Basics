using System;



class Program
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        string town = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        if (town == "Sofia")
        {
            if (product == "coffee")
            {
                Console.WriteLine(Math.Round((quantity * 0.5), 1));
            }
            else if (product == "water")
            {
                Console.WriteLine(quantity * 0.8);
            }
            else if (product == "beer")
            {
                Console.WriteLine(quantity * 1.2);
            }
            else if (product == "sweets")
            {
                Console.WriteLine(quantity * 1.45);
            }
            else if (product == "peanuts")
            {
                Console.WriteLine(quantity * 1.6);
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine("1.2");
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.3);
                }
                else if (product == "peanuts")
                {
                    double result = quantity * 1.5;
                    Console.WriteLine("{0:f1}", result);
                }
            }

        }
        else
        {
            if (product == "coffee")
            {
                Console.WriteLine(quantity * 0.45);
            }
            else if (product == "water")
            {
                Console.WriteLine(quantity * 0.70);
            }
            else if (product == "beer")
            {
                Console.WriteLine(quantity * 1.10);
            }
            else if (product == "sweets")
            {
                Console.WriteLine(quantity * 1.35);
            }
            else if (product == "peanuts")
            {
                Console.WriteLine(quantity * 1.55);
            }
        }

    }
}

