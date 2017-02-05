using System;



class Program
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string sex = Console.ReadLine().ToLower();

        if (sex == "f")
        {
            if (age < 16)
            {
                Console.WriteLine("Miss");
            }
            else
            {
                Console.WriteLine("Ms.");
            }
        }
        else if (sex == "m")
        {
            if (age < 16)
            {
                Console.WriteLine("Master");
            }
            else
            {
                Console.WriteLine("Mr.");
            }
        }

    }
}

