using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt16(Console.ReadLine());
            int sayi2 = Convert.ToInt16(Console.ReadLine());
            if (sayi > sayi2)
            {
                if (sayi % sayi2 == 0)
                {
                    Console.WriteLine(sayi + " ve " + sayi2 + " " + "birbirine tam bölünür");
                }
                else
                {
                    Console.WriteLine(sayi + " ve " + sayi2 + " " + "tam bölünmez");
                }

            }

            Console.ReadKey();

        }
    }
}
