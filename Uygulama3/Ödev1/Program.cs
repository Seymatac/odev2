using System;
using System.Linq;

namespace Ödev1
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayı1 = Convert.ToInt16(Console.ReadLine());
            int sayı2 = Convert.ToInt16(Console.ReadLine());
            if (sayı1 > sayı2)
            {
                if (sayı1 % sayı2 == 0)
                {
                    Console.WriteLine(sayı1 + " " + sayı2 + " " + "birbirine tam bölünüyor.");
                }
                else
                {
                    Console.WriteLine(sayı1 + " " + sayı2 + " " + "birbirine tam bölünmüyor");
                }
            }
            Console.ReadKey();
        }




    }
}

