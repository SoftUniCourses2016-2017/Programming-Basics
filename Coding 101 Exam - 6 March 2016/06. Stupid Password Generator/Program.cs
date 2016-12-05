using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    for (char k = 'a'; k <= l + 96; k++)
                    {
                        for (char m = 'a'; m <= l + 96; m++)
                        {
                            for (int o = Math.Max(i, j) + 1; o <= n; o++)
                            {
                                Console.Write(i);
                                Console.Write(j);
                                Console.Write(k);
                                Console.Write(m);
                                Console.Write(o + " ");
                            }

                        }

                    }
                }
            }
            Console.WriteLine();
        }
    }
}
