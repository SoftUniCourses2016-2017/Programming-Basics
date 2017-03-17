using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3___Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            decimal priceForApartment = 0;
            decimal priceForStudio = 0;
            if (month == "May" || month == "October")
            {
                if (nights <= 7)
                {
                    priceForApartment = 65;
                    priceForStudio = 50;
                }
                else if (nights > 7 && nights <= 14)
                {
                    priceForApartment = 65;
                    priceForStudio = 50 - (50 * 5m / 100);
                }
                else
                {
                    priceForApartment = 65 - (65 * 10m / 100);
                    priceForStudio = 50 - (50 * 30m / 100);
                }
            }
            if (month == "June" || month == "September")
            {
                if (nights <= 7 || nights <= 14)
                {
                    priceForApartment = 68.70m;
                    priceForStudio = 75.20m;

                }
                else if (nights > 14)
                {
                    priceForApartment = 68.70m - (68.70m * 10m / 100);
                    priceForStudio = 75.20m - (75.20m * 20m / 100);
                }
            }
            if (month == "July" || month == "August")
            {
                if (nights <= 7 || nights <= 14)
                {
                    priceForApartment = 77;
                    priceForStudio = 76;
                }
                else
                {
                    priceForApartment = 77 - (77 * 10m / 100);
                    priceForStudio = 76;
                }
            }
            Console.WriteLine($"Apartment: {priceForApartment * nights:F2} lv.");
            Console.WriteLine($"Studio: {priceForStudio * nights:F2} lv.");
        }
    }
}
