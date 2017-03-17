using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni17jul2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double sumGrapes = x * y;
            double wine = 0.4 * sumGrapes / 2.5;

            if (wine < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - wine)} liters wine needed.");

            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - z)} liters left -> {Math.Ceiling(Math.Ceiling(wine - z) / workers)} liters per person.");
            }
            Console.ReadLine();
        }
    }
}
