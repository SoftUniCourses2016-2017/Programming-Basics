using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersPokemons1 = int.Parse(Console.ReadLine());
            int numbersPokemons2 = int.Parse(Console.ReadLine());
            int maxNumberBattles = int.Parse(Console.ReadLine());
            int combinations = 0;


            for (int j = 1; j <= numbersPokemons1; j++)
            {
                for (int k = 1; k <= numbersPokemons2; k++)
                {
                    if (combinations != maxNumberBattles)
                    {
                        Console.Write($"({j} <-> {k}) ");
                        combinations++;

                    }

                }

            }
            Console.WriteLine();

        }
    }
}
