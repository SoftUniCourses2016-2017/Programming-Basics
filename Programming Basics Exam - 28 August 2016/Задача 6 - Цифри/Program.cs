using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6___Цифри
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstDigit = Convert.ToInt32(n.ToString().Substring(0, 1));
            int secondDigit = Convert.ToInt32(n.ToString().Substring(1, 1));
            int lastDigit = Convert.ToInt32(n.ToString().Substring(2, 1));

            for (int row = 0; row < firstDigit + secondDigit; row++)
            {
                for (int col = 0; col < firstDigit + lastDigit; col++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - firstDigit;
                        Console.Write("{0} ", n);
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - secondDigit;
                        Console.Write("{0} ", n);
                    }
                    else
                    {
                        n = n + lastDigit;
                        Console.Write("{0} ", n);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
