using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Tycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int torti = int.Parse(Console.ReadLine());
            double kgBrashno = double.Parse(Console.ReadLine());
            double kgNalichno = double.Parse(Console.ReadLine());
            double trufeli = double.Parse(Console.ReadLine());
            double cenaTrufeli = double.Parse(Console.ReadLine());

            double razhodTrufeli = trufeli * cenaTrufeli;
            double gotoviTorti = Math.Floor(kgNalichno / kgBrashno);

            if (torti > gotoviTorti)
            {
                double kg = (kgBrashno * torti) - kgNalichno;
                Console.WriteLine($"Can make only {gotoviTorti} cakes, need {kg:f2} kg more flour");
            }
            else
            {
                double razhodTorti = (razhodTrufeli / torti) * 1.25;
                Console.WriteLine($"All products available, price of a cake: {razhodTorti:f2}");
            }
        }
    }
}
