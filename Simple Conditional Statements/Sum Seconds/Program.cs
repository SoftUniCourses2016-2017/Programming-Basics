using System;



class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int sum = num1 + num2 + num3;

        int minutes = sum / 60;
        int seconds = sum % 60;
        string secondsAsstring = seconds.ToString();
        if (seconds < 10)
        {
            secondsAsstring = 0 + secondsAsstring;
        }

        Console.WriteLine("{0}:{1}", minutes, secondsAsstring);

    }
}

