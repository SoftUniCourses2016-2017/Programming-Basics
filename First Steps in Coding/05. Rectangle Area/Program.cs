using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactangleArea1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = int.Parse(Console.ReadLine());
            var area = a * b;
            Console.Write("Sqare = ");
            Console.WriteLine(area);
        }
    }
}
