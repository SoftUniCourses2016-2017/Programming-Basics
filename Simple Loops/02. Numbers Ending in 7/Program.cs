using System;

class Program
{
    static void Main()
    {
        for (int i = 7; i <= 1000; i++)
        {
            int num = i;
            if (num % 10 == 7)
            {
                Console.WriteLine(num);
            }
        }
    }
}

