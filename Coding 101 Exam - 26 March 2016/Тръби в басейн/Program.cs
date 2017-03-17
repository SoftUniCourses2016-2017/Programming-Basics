using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_02___Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            double volumeOfThePool = double.Parse(Console.ReadLine());
            double p1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            double workerHoursOfMissing = double.Parse(Console.ReadLine());
            double firstPipeFilled = workerHoursOfMissing * p1;
            double secondPipeFilled = workerHoursOfMissing * p2;
            if (volumeOfThePool >= firstPipeFilled + secondPipeFilled)
            {
                double percentsFullPool = (int)((firstPipeFilled + secondPipeFilled) * 100 / volumeOfThePool);
                double percentsPipe1 = (int)(firstPipeFilled * 100 / (firstPipeFilled + secondPipeFilled));
                double percentsPipe2 = (int)(secondPipeFilled * 100 / (firstPipeFilled + secondPipeFilled));

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentsFullPool, percentsPipe1, percentsPipe2);
            }
            else
            {

                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", workerHoursOfMissing, (firstPipeFilled + secondPipeFilled) - volumeOfThePool);
            }





        }
    }
}
