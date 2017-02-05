using System;



class Program
{
    static void Main()
    {
        string fruit = Console.ReadLine().ToLower();
        string day = Console.ReadLine();
        var quantity = decimal.Parse(Console.ReadLine());

        if (day == "Saturday" || day == "Sunday")
        {
            if (fruit == "banana")
            {
                Console.WriteLine("{0:0.00}", quantity * 2.70m);
            }
            if (fruit == "apple")
            {
                Console.WriteLine("{0:0.00}", quantity * 1.25m);
            }
            else if (fruit == "orange")
            {
                Console.WriteLine("{0:0.00}", quantity * 0.9m);
            }
            else if (fruit == "grapefruit")
            {
                Console.WriteLine("{0:0.00}", quantity * 1.60m);
            }
            else if (fruit == "kiwi")
            {
                Console.WriteLine("{0:0.00}", quantity * 3.00m);
            }
            else if (fruit == "pineapple")
            {
                Console.WriteLine("{0:0.00}", quantity * 5.60m);
            }
            else if (fruit == "grapes")
            {
                Console.WriteLine("{0:0.00}", quantity * 4.20m);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
        {
            if (fruit == "banana")
            {
                Console.WriteLine("{0:0.00}", quantity * 2.50m);
            }
            if (fruit == "apple")
            {
                Console.WriteLine("{0:0.00}", quantity * 1.20m);
            }
            else if (fruit == "orange")
            {
                Console.WriteLine("{0:0.00}", quantity * 0.85m);
            }
            else if (fruit == "grapefruit")
            {
                Console.WriteLine("{0:0.00}", quantity * 1.45m);
            }
            else if (fruit == "kiwi")
            {
                Console.WriteLine("{0:0.00}", quantity * 2.70m);
            }
            else if (fruit == "pineapple")
            {
                Console.WriteLine("{0:0.00}", quantity * 5.50m);
            }
            else if (fruit == "grapes")
            {
                Console.WriteLine("{0:0.00}", quantity * 3.85m);
            }
            else
            {
                Console.WriteLine("error");
            }


        }
        else
        {
            Console.WriteLine("error");
        }


    }
}

