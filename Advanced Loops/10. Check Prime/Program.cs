using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool prime = true;

        if (n < 2)
        {
            Console.WriteLine("Not prime");
            return;
        }
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                prime = false;
                break;
            }
        }

        if (prime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not prime");
        }
    }
}

