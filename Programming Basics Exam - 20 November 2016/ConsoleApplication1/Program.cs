using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriya = double.Parse(Console.ReadLine());
            double caca = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            double midiKg = double.Parse(Console.ReadLine());

            double pricePalamud = (skumriya + skumriya * 60 / 100) * palamudKg;
            double priceSafrid = (caca + caca * 80 / 100) * safridKg;
            double priceMidi = midiKg * 7.50;
            Console.WriteLine("{0:F2}", priceSafrid + pricePalamud + priceMidi);


        }
    }
}
