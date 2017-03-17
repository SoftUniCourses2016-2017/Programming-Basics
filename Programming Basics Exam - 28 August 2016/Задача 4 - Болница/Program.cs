using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4___Болница
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int sumTreated = 0;
            int sumUntreated = 0;

            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0 && sumUntreated > sumTreated)
                {
                    doctors++;
                }
                int patients = int.Parse(Console.ReadLine());

                if (patients == doctors)
                {
                    treatedPatients = doctors;
                    sumTreated = sumTreated + treatedPatients;
                    untreatedPatients = 0;
                }
                if (patients < doctors)
                {
                    treatedPatients = patients;
                    sumTreated = sumTreated + treatedPatients;
                    untreatedPatients = 0;
                }
                if (patients > doctors)
                {
                    treatedPatients = doctors;
                    untreatedPatients = patients - treatedPatients;
                    sumTreated = sumTreated + treatedPatients;
                    sumUntreated = sumUntreated + untreatedPatients;

                }

            }
            Console.WriteLine($"Treated patients: {sumTreated}.");
            Console.WriteLine($"Untreated patients: {sumUntreated}.");


        }
    }
}
