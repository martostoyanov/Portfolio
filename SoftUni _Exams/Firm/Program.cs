using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double chasove = double.Parse(Console.ReadLine());
            double dni = double.Parse(Console.ReadLine());
            double slujiteli = double.Parse(Console.ReadLine());

            double obuchenie = (dni - (dni * 0.10)) * 8;
            double izvanredno = slujiteli * (2 * dni);
            double obshtoVreme = obuchenie + izvanredno;

            if (obshtoVreme >= chasove)
            {
                obshtoVreme = obshtoVreme - chasove;
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(obshtoVreme));
            }
            else if (chasove > obshtoVreme)
            {
                obshtoVreme = chasove - obshtoVreme;
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(obshtoVreme));
            }
        }
    }
}
