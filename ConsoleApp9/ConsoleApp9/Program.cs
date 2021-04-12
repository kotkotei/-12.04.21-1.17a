using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {//1.17 a
            Console.WriteLine("Введите число x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x1x2 =Math.Sqrt (Math.Pow(x1, 2) + Math.Pow(x2, 2));

            Console.WriteLine("Ответ:" + x1x2);
            Console.ReadKey();

            Console.WriteLine("Введите число b1");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b2");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b3");
            double b3 = Convert.ToDouble(Console.ReadLine());
            double b1b2b3 = b1 * b2 + b1 * b3 + b2 * b3;
            Console.WriteLine("Ответ:" + b1b2b3);
            Console.ReadKey();













        }
    }
}
