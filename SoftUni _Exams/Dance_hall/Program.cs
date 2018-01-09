using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dance_hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double dalzhina = double.Parse(Console.ReadLine());
            double shirochina = double.Parse(Console.ReadLine());
            double garderobStrana = double.Parse(Console.ReadLine());

            double zala = dalzhina * 100 * shirochina * 100;
            double garderob = garderobStrana * 100 * garderobStrana * 100;
            double skameika = zala / 10;

            double svobodnoMqsto = (zala - garderob - skameika) / (40 + 7000);

            Console.WriteLine(Math.Floor(svobodnoMqsto));
        }
    }
}
