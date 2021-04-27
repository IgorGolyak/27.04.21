using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.71
            double s = 1000;
            for (int i = 1; i <= 10; i = i + 1)
            {
                double s1 = s / 100.0 * 2 + s;
                double ds = s1 - s;
                Console.WriteLine(ds);
                s = s1;
            }
            Console.ReadKey();

        }
    }
}
