using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x1, x2, delta;
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta) / (2 * a));
                x2 = (-b - Math.Sqrt(delta) / (2 * a));
                Console.WriteLine(x1 + " " + x2);
            }
            else if (delta == 0)
            {
                x1 = x2 = (-b) / (2 * a);
                Console.WriteLine("kökler birbirine eşittir");
            }
            else
                 Console.WriteLine("reel kök yoktur");

            Console.ReadKey();
        }
    }
}
