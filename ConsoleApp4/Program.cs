using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.67 b
            Console.WriteLine("Введите номер элемента");
            int k = Convert.ToInt32(Console.ReadLine());
            int a1 = 1;
            int a2 = 1;
            Console.WriteLine("Элемент № 1  равен " + a1);
            Console.WriteLine("Элемент № 2  равен " + a2);
            for (int i = 3; i <= k; i++)
            {
                int a = a1 + a2;
                a1 = a2;
                a2 = a;
                Console.WriteLine("Элемент № " + i + " равен " + a2);
            }
            Console.ReadKey();
        }
    }
}
