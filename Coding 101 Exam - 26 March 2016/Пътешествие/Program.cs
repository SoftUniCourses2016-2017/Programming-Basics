using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_03___Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double partOfBudget = 0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    partOfBudget = budget * 30 / 100;
                    Console.WriteLine("Camp - {0:F2}", partOfBudget);
                }
                else
                {
                    partOfBudget = budget * 70 / 100;
                    Console.WriteLine("Hotel - {0:F2}", partOfBudget);
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    partOfBudget = budget * 40 / 100;
                    Console.WriteLine("Camp - {0:F2}", partOfBudget);
                }
                else
                {
                    partOfBudget = budget * 80 / 100;
                    Console.WriteLine("Hotel - {0:F2}", partOfBudget);
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                partOfBudget = budget * 90 / 100;
                Console.WriteLine("Hotel - {0:F2}", partOfBudget);
            }
        }
    }
}


