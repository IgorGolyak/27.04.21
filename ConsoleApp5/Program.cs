using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.70
            int a = 1;
            for (int i = 3; i <= 24; i=i+3)
            {
                a = a * 2;
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
