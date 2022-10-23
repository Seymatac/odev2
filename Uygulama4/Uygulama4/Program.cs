using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4
{     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("herhangi bir tarih giriniz.");
            DateTime tarih = DateTime.Now;
            Console.WriteLine(tarih.Day + "." + tarih.Month + "." + tarih.Year);
            int ay = (int)DateTime.Now.Month;

            switch (ay)
            {
                case 1: Console.Write("ocak"); break;
                case 2: Console.Write("şubat"); break;
                case 3: Console.Write("mart"); break;
                case 4: Console.Write("misan"); break;
                case 5: Console.Write("mayıs"); break;
                case 6: Console.Write("haziran"); break;
                case 7: Console.Write("temmuz"); break;
                case 8: Console.Write("ağustos"); break;
                case 9: Console.Write("eylül"); break;
                case 10: Console.Write("ekim"); break;
                case 11: Console.Write("kasım"); break;
                case 12: Console.Write("aralık"); break;
                default:; break;
            }
            Console.ReadKey();
      }
    }
}
