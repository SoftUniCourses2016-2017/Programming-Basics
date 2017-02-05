using System;

class Program
{
    static void Main()
    {
        var input = double.Parse(Console.ReadLine());

        bool isInRange = (input >= 100 && input <= 200) || (input == 0);
        if (!isInRange)
        {
            Console.WriteLine("invalid");
        }
    }
}