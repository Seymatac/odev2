using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama6
{
    class Program
    {
        static void Main(string[] args)
        {
            int derece;
            double radyan, gradyan;
            double pisayısı = 3.14;
            derece = Convert.ToInt16(Console.ReadLine());
            gradyan = 1.11 * derece;
            radyan = (derece * pisayısı / 180);
            Console.WriteLine("gradyan değeri:" + gradyan);
            Console.WriteLine("radyan değeri:" + radyan);


            Console.ReadKey();

        


        }
    }
}
