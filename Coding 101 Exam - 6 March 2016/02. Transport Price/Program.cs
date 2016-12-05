using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            decimal price = 0;
            if (timeOfDay == "day")
            {
                if (km < 20)
                {
                    price = 0.70m + km * 0.79m;
                }
                else if (km >= 20 && km < 100)
                {
                    price = 0.09m * km;
                }
                else
                {
                    price = 0.06m * km;
                }
            }
            else if (timeOfDay == "night")
            {
                if (km < 20)
                {
                    price = 0.70m + km * 0.90m;
                }
                else if (km >= 20 && km < 100)
                {
                    price = 0.09m * km;
                }
                else
                {
                    price = 0.06m * km;
                }
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
