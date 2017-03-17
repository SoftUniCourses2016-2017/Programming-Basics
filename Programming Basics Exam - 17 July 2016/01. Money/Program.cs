using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoinsNumber = int.Parse(Console.ReadLine());
            double chineeseUan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double BitcoinsToLevas = bitcoinsNumber * 1168;
            double uansToDollars = chineeseUan * 0.15;
            double dollarsToLevas = uansToDollars * 1.76;
            double euros = (BitcoinsToLevas + dollarsToLevas) / 1.95;
            double eurosWithoutCommission = euros * commission / 100;
            Console.WriteLine(euros - eurosWithoutCommission);
        }
    }
}
