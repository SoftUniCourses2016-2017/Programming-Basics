using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_01___Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerKgVegetables = double.Parse(Console.ReadLine());
            double pricePerKgFruits = double.Parse(Console.ReadLine());
            int kgVegetables = int.Parse(Console.ReadLine());
            int kgFruits = int.Parse(Console.ReadLine());
            double priceOfVegetables = pricePerKgVegetables * kgVegetables;
            double priceOfFruits = pricePerKgFruits * kgFruits;
            Console.WriteLine($"{(priceOfVegetables / 1.94d) + (priceOfFruits / 1.94d)}");
        }
    }
}
