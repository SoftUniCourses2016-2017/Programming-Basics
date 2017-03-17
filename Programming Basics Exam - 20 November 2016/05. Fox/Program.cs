using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 3;

            int middlePart = 2 * n - 1;
            int leftPart = (width - middlePart - 2) / 2;
            int rightPart = leftPart;
            int middle = n;
            int left = ((width - 4 - n) / 2);
            int right = left;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', leftPart), new string('-', middlePart));
                leftPart++;
                rightPart++;
                middlePart -= 2;
            }


            for (int i = 0; i < n / 3; i++)
            {

                Console.WriteLine("|{0}\\{1}/{2}|", new string('*', left), new string('*', middle), new string('*', right));
                middle -= 2;
                left++;
                right++;
            }
            middlePart = 2 * n - 1;
            leftPart = (width - middlePart - 2) / 2;
            rightPart = (width - middlePart - 2) / 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', leftPart), new string('*', middlePart), new string('-', rightPart));
                leftPart++;
                rightPart++;
                middlePart -= 2;
            }


        }

    }




}



