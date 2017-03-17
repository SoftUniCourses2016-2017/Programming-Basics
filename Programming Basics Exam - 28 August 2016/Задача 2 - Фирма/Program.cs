using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2___Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int daysFirm = int.Parse(Console.ReadLine());
            int workersOvertime = int.Parse(Console.ReadLine());
            double percents = daysFirm * 8.00 * 10.00 / 100.00;
            double workingHours = daysFirm * 8 - percents;
            int hoursOvertime = workersOvertime * (2 * daysFirm);
            double sumHours = Math.Floor(workingHours + hoursOvertime);
            double leftHours = Math.Abs(neededHours - sumHours);

            if (neededHours > sumHours)
            {
                Console.WriteLine($"Not enough time!{leftHours} hours needed.");
            }
            else
            {
                Console.WriteLine($"Yes!{leftHours} hours left.");
            }

        }
    }
}
