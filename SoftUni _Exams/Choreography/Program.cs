using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double broiStapki = double.Parse(Console.ReadLine());
            double broiTanciori = double.Parse(Console.ReadLine());
            double dniUchene = double.Parse(Console.ReadLine());

            //double procent = (broiStapki / dniUchene) / broiStapki;
            double procent = Math.Ceiling(1 * 100 / dniUchene);
            double procentTancior = procent / broiTanciori;

            if (procent <= 13) //(procent <= 0.13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", procentTancior);
            }
            else if (procent > 13)
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", procentTancior);
            }
        }
    }
}
