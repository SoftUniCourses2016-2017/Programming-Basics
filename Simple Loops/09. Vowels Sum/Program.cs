using System;


class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        int vowelsSum = 0;

        for (int i = 0; i < word.Length; i++)
        {
            switch (word[i])
            {
                case 'a':
                    vowelsSum += 1;
                    break;
                case 'e':
                    vowelsSum += 2;
                    break;
                case 'i':
                    vowelsSum += 3;
                    break;
                case 'o':
                    vowelsSum += 4;
                    break;
                case 'u':
                    vowelsSum += 5;
                    break;


            }
        }
        Console.WriteLine(vowelsSum);
    }
}

