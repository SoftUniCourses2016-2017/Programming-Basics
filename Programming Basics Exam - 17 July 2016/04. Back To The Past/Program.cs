using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyFromLegacy = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            double moneyLeft = moneyFromLegacy - 12000;

            for (int i = 1801; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    moneyLeft = moneyLeft - 12000;
                }
                else
                {
                    moneyLeft = moneyLeft - (12000 + (50 * (i - 1800 + 18)));
                }
            }
            if (moneyLeft >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", moneyLeft);
            }
            else if (moneyLeft < 0)
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(moneyLeft));
            }

        }
    }
}
