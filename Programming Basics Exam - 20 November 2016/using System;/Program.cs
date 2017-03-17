using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOldPeople = int.Parse(Console.ReadLine());
            int numberStudents = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double priceFortransport = 0;
            double totalPrice = 0;
            double commission = 0;

            if (transport == "train")
            {
                if (numberOldPeople + numberStudents >= 50)
                {
                    priceFortransport = (numberOldPeople * 24.99) + (numberStudents * 14.99);
                    commission = (priceFortransport + (nights * 82.99)) * 10 / 100;
                    totalPrice = priceFortransport + (nights * 82.99) + commission;
                }
                else
                {
                    priceFortransport = ((numberOldPeople * 24.99) + (numberStudents * 14.99)) * 2;
                    commission = (priceFortransport + (nights * 82.99)) * 10 / 100;
                    totalPrice = priceFortransport + (nights * 82.99) + commission;
                }


            }
            else if (transport == "bus")
            {
                priceFortransport = ((numberOldPeople * 32.50) + (numberStudents * 28.50)) * 2;
                commission = (priceFortransport + (nights * 82.99)) * 10 / 100;
                totalPrice = priceFortransport + (nights * 82.99) + commission;
            }
            else if (transport == "boat")
            {
                priceFortransport = ((numberOldPeople * 42.99) + (numberStudents * 39.99)) * 2;
                commission = (priceFortransport + (nights * 82.99)) * 10 / 100;
                totalPrice = priceFortransport + (nights * 82.99) + commission;
            }
            else
            {
                priceFortransport = ((numberOldPeople * 70.00) + (numberStudents * 50.00)) * 2;
                commission = (priceFortransport + (nights * 82.99)) * 10 / 100;
                totalPrice = priceFortransport + (nights * 82.99) + commission;
            }
            Console.WriteLine("{0:F2}", totalPrice);

        }
    }
}
