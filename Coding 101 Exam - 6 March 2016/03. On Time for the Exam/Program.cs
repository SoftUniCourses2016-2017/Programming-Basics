using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArriving = int.Parse(Console.ReadLine());
            int minutesArriving = int.Parse(Console.ReadLine());
            int totalMinutesExam = hourExam * 60 + minutesExam;
            int totalMinutesArriving = hourArriving * 60 + minutesArriving;

            if (totalMinutesExam == totalMinutesArriving)
            {
                Console.WriteLine("On time");
            }

            else if (totalMinutesExam - totalMinutesArriving <= 30 && totalMinutesExam - totalMinutesArriving != 0 && totalMinutesExam - totalMinutesArriving > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", totalMinutesExam - totalMinutesArriving);
            }
            else if (totalMinutesArriving > totalMinutesExam && totalMinutesArriving - totalMinutesExam < 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", totalMinutesArriving - totalMinutesExam);
            }
            else if (totalMinutesArriving > totalMinutesExam && totalMinutesArriving - totalMinutesExam >= 60)
            {
                if ((totalMinutesArriving - totalMinutesExam) % 60 < 10)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:0{1} hours after the start", (totalMinutesArriving - totalMinutesExam) / 60, (totalMinutesArriving - totalMinutesExam) % 60);
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1} hours after the start", (totalMinutesArriving - totalMinutesExam) / 60, (totalMinutesArriving - totalMinutesExam) % 60);
                }

            }
            else if (totalMinutesExam > totalMinutesArriving && totalMinutesExam - totalMinutesArriving >= 30 && totalMinutesExam - totalMinutesArriving < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", totalMinutesExam - totalMinutesArriving);
            }
            else if (totalMinutesExam > totalMinutesArriving && totalMinutesExam - totalMinutesArriving >= 60)
            {
                if ((totalMinutesExam - totalMinutesArriving) % 60 < 10)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:0{1} hours before the start", (totalMinutesExam - totalMinutesArriving) / 60, (totalMinutesExam - totalMinutesArriving) % 60);
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1} hours before the start", (totalMinutesExam - totalMinutesArriving) / 60, (totalMinutesExam - totalMinutesArriving) % 60);
                }
            }
        }
    }
}
