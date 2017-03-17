using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodKgForDays = double.Parse(Console.ReadLine());
            double dogsFoodPerDayKg = double.Parse(Console.ReadLine());
            double catsFoodPerDayKg = double.Parse(Console.ReadLine());
            double turtleFoodPerDayG = double.Parse(Console.ReadLine());

            double neededFood = (days * dogsFoodPerDayKg) + (days * catsFoodPerDayKg) + (days * turtleFoodPerDayG / 1000);
            if (neededFood <= foodKgForDays)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodKgForDays - neededFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(neededFood - foodKgForDays));
            }



        }
    }
}
