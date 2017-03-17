using System;

class Program
{
    static void Main()
    {
        int restDays = int.Parse(Console.ReadLine());
        int workingDays = 365 - restDays;
        int realTimeForPlay = ((workingDays * 63) + (restDays * 127));
        int diff = Math.Abs(30000 - realTimeForPlay);

        if (realTimeForPlay > 30000)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", diff / 60, realTimeForPlay % 60);
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", diff / 60, diff % 60);
        }
    }
}

