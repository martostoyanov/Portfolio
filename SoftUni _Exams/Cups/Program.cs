using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiChashi = int.Parse(Console.ReadLine());
            int broiRabotnici = int.Parse(Console.ReadLine());
            int rabotniDni = int.Parse(Console.ReadLine());

            double chasove = (broiRabotnici * rabotniDni) * 8;
            double gotoviChashi = Math.Floor(chasove / 5);

            if (broiChashi > gotoviChashi)
            {
                double zagubi = (broiChashi - gotoviChashi) * 4.20;
                Console.WriteLine("Losses: {0:f2}", zagubi);
            }
            else if (gotoviChashi >=broiChashi)
            {
                double pechalba = (gotoviChashi - broiChashi) * 4.20;
                Console.WriteLine("{0:f2} extra money", pechalba);
            }
        }
    }
}
