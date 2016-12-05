using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int heigth = n;
            int middle = 0;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string('_', width - (2 * (n / 2) + 4)));


            for (int i = 0; i <= heigth - 3; i++)
            {
                if (i != heigth - 3)
                {
                    Console.WriteLine("|{0}|", new string(' ', width - 2));
                }

                else if (i == heigth - 3 )
                {
                    Console.WriteLine("|{0}{1}{0}|", new string(' ', (n / 2) + 1), new string('_', width - (2 * (n / 2) + 4)));
                }

            }
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', width - (2 * (n / 2) + 4)));


        }
    }
}
