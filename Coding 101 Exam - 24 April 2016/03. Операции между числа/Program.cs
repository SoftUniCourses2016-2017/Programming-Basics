using System;

class Program
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        string selection = Console.ReadLine();

        if (selection == "+")
        {
            int result = n1 + n2;
            if (result % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", n1,
                    selection, n2, result);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} = {3} - odd", n1,
                    selection, n2, result);
            }
        }
        else if (selection == "-")
        {
            int result = n1 - n2;
            if (result % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", n1,
                    selection, n2, result);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} = {3} - odd", n1,
                    selection, n2, result);
            }
        }
        else if (selection == "*")
        {
            int result = n1 * n2;
            if (result % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", n1,
                    selection, n2, result);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} = {3} - odd", n1,
                    selection, n2, result);
            }
        }
        else if (selection == "/")
        {
            if (n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else
            {

                Console.WriteLine("{0} / {1} = {2:F2}", n1, n2, (double)n1 / n2);
            }
        }
        else if (selection == "%")
        {
            if (n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else
            {

                Console.WriteLine("{0} % {1} = {2}", n1, n2, n1 % n2);
            }
        }

    }
}

