using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohod = double.Parse(Console.ReadLine());
            double sredenUspeh = double.Parse(Console.ReadLine());
            double minimalnaZaplata = double.Parse(Console.ReadLine());

            double socStipendiq = minimalnaZaplata * 0.35;
            double uspehStipendiq = sredenUspeh * 25;

            if (sredenUspeh >= 4.50 && sredenUspeh < 5.50)
            {
                if (dohod > minimalnaZaplata)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (minimalnaZaplata > dohod)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socStipendiq));
                }
            }
            else if (sredenUspeh >= 5.50 && sredenUspeh <= 6)
            {
                if (socStipendiq > uspehStipendiq)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socStipendiq));
                }
                else if (uspehStipendiq >= socStipendiq)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(uspehStipendiq));
                }
            }
        }
    }
}
