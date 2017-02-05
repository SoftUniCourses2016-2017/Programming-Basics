using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int num = 1; num <= number; num++)
        {
            int numbers = int.Parse(Console.ReadLine());
            sum = sum + numbers;
        }
        Console.WriteLine(sum);
    }
}

