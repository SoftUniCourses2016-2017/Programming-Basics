using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int leftDots = n;
            int middleDots = 3 * n;
            int rightDots = n;
            int height = 3 * n + 2;
            Console.WriteLine("{0}{1}{2}", new string('.', leftDots), new string('*', middleDots), new string('.', rightDots));
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('.', leftDots - 1), new string('.', middleDots), new string('.', rightDots - 1));
                leftDots--;
                rightDots--;
                middleDots += 2;
            }
            Console.WriteLine(new string('*', width));
            for (int i = 0; i < height - n - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('.', leftDots), new string('.', Math.Abs(middleDots - 2)), new string('.', rightDots));
                leftDots++;
                rightDots++;
                middleDots -= 2;
            }
            Console.WriteLine("{0}{1}{2}", new string('.', leftDots), new string('*', middleDots), new string('.', rightDots));
        }
    }
}
