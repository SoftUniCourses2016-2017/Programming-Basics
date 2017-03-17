using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberPeople = int.Parse(Console.ReadLine());
            double leftMoney = 0;

            if (numberPeople <= 4)
            {
                leftMoney = budget - (budget * 75 / 100);
            }
            else if (numberPeople >= 5 && numberPeople <= 9)
            {
                leftMoney = budget - (budget * 60 / 100);
            }
            else if (numberPeople >= 10 && numberPeople <= 24)
            {
                leftMoney = budget - (budget * 50 / 100);
            }
            else if (numberPeople >= 25 && numberPeople <= 49)
            {
                leftMoney = budget - (budget * 40 / 100);
            }
            else
            {
                leftMoney = budget - (budget * 25 / 100);
            }

            if (category == "VIP")
            {
                if (leftMoney >= 499.99 * numberPeople)
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", leftMoney - (499.99 * numberPeople));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (499.99 * numberPeople) - leftMoney);
                }
            }
            else
            {
                if (leftMoney >= 249.99 * numberPeople)
                {

                    Console.WriteLine("Yes! You have {0:F2} leva left.", leftMoney - (249.99 * numberPeople));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (249.99 * numberPeople) - leftMoney);
                }

            }
        }
    }
}
