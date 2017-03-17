using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double car = 0;
            double microbus = 0;
            double miniBus = 0;
            double hugeBus = 0;
            double train = 0;
            int allPeople = 0;


            for (int i = 0; i < n; i++)
            {
                int membersGroup = int.Parse(Console.ReadLine());
                if (membersGroup <= 5)
                {
                    car = car + membersGroup;

                }
                else if (membersGroup >= 6 && membersGroup <= 12)
                {
                    microbus = microbus + membersGroup;
                }
                else if (membersGroup >= 13 && membersGroup <= 25)
                {
                    miniBus = miniBus + membersGroup;
                }
                else if (membersGroup >= 26 && membersGroup <= 40)
                {
                    hugeBus = hugeBus + membersGroup;
                }
                else
                {
                    train = train + membersGroup;
                }
                allPeople = allPeople + membersGroup;

            }
            Console.WriteLine("{0:F2}%", car / allPeople * 100);
            Console.WriteLine("{0:F2}%", microbus / allPeople * 100);
            Console.WriteLine("{0:F2}%", miniBus / allPeople * 100);
            Console.WriteLine("{0:F2}%", hugeBus / allPeople * 100);
            Console.WriteLine("{0:F2}%", train / allPeople * 100);

        }
    }
}
