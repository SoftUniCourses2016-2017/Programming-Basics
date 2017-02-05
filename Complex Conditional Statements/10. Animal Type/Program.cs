using System;

class Program
{
    static void Main()
    {
        string animal = Console.ReadLine().ToLower();

        switch (animal)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "tortoise":
            case "crocodile":
            case "snake":
                Console.WriteLine("reptile");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}

