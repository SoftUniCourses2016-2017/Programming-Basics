using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var Oddsum = 0d;
            var Oddmax = double.MinValue;
            var Oddmin = double.MaxValue;
            var Esum = 0d;
            var Emax = double.MinValue;
            var Emin = double.MaxValue;


            if (num == 0)
            {
                Console.WriteLine("Oddsum=" + num);
                Console.WriteLine("Oddmin=No");
                Console.WriteLine("Oddmax=No");
                Console.WriteLine("Evensum=" + num);
                Console.WriteLine("Evenmin=No");
                Console.WriteLine("Evenmax=No");


            }
            else if (num == 1)
            {
                var curr = double.Parse(Console.ReadLine());
                Console.WriteLine("Oddsum=" + curr);
                Console.WriteLine("Oddmin=" + curr);
                Console.WriteLine("Oddmax=" + curr);
                Console.WriteLine("Evensum=0");
                Console.WriteLine("Evenmin=No");
                Console.WriteLine("Evenmax=No");

            }
            else
            {
                for (int i = 1; i <= num; i++)
                {

                    var curr = double.Parse(Console.ReadLine());

                    if (i % 2 != 0)
                    {
                        Oddsum = Oddsum + curr;
                        if (curr > Oddmax)
                        {
                            Oddmax = curr;
                        }
                        if (curr < Oddmin)
                        {
                            Oddmin = curr;
                        }
                    }
                    else if (i % 2 == 0)
                    {
                        Esum = Esum + curr;
                        if (curr > Emax)
                        {
                            Emax = curr;
                        }
                        if (curr < Emin)
                        {
                            Emin = curr;
                        }
                    }


                }

                Console.WriteLine("Oddsum=" + Oddsum);
                Console.WriteLine("Oddmin=" + Oddmin);
                Console.WriteLine("Oddmax=" + Oddmax);
                Console.WriteLine("Evensum=" + Esum);
                Console.WriteLine("Evenmin=" + Emin);
                Console.WriteLine("Evenmax=" + Emax);

            }

        }
    }
}