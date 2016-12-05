using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double widthInSm = width * 100;
            double heightInSm = height * 100;
            double leftSmWidth = widthInSm - 100;
            int desksOnRow = (int)leftSmWidth / 70;
            int desksOnRow2 = (int)heightInSm / 120;
            Console.WriteLine(desksOnRow * desksOnRow2 - 3);
        }
    }
}
