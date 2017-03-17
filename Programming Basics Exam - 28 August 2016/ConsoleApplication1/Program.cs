using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_01___Дневна_печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysInMonth = int.Parse(Console.ReadLine());
            decimal earnedMoneyPerDay = decimal.Parse(Console.ReadLine());
            decimal courseDollarAgainstLev = decimal.Parse(Console.ReadLine());

            decimal monthSalary = workingDaysInMonth * earnedMoneyPerDay;
            decimal yearSalary = (monthSalary * 12) + (monthSalary * 2.5m);
            decimal danuk = yearSalary * 25 / 100;
            decimal yearSalaryAfterDLevas = (yearSalary - danuk) * courseDollarAgainstLev;
            decimal avarageEarnPerDay = yearSalaryAfterDLevas / 365;
            Console.WriteLine($"{avarageEarnPerDay:F2}");


        }
    }
}
