using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int blankSpaces = n - 1;

        for (int row = 1; row <= n; row++)
        {
            Console.Write("{0}", new string(' ', blankSpaces));

            for (int col = 0; col < row; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            blankSpaces--;

        }
        blankSpaces = 1;
        for (int row = n - 1; row > 0; row--)
        {
            Console.Write("{0}", new string(' ', blankSpaces));
            for (int col = row; col > 0; col--)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            blankSpaces++;
        }
    }
}

