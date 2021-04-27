using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.51
            Console.WriteLine("Введите количество слагаемых");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("Введите число №" + i);
                int a = Convert.ToInt32(Console.ReadLine());
                s = s + a;
            }
            double sr = (s * 1.0) / n;
            Console.WriteLine("sr=" + sr);
            Console.ReadKey();
        }
    }
}
