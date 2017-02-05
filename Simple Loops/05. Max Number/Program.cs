using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int maxNumber = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            int numbersForCheck = int.Parse(Console.ReadLine());
            if (numbersForCheck > maxNumber)
            {
                maxNumber = numbersForCheck;
            }
            Console.WriteLine(maxNumber);
        }

    }
}

