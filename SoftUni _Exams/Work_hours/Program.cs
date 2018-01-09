using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            double chasove = double.Parse(Console.ReadLine());
            int rabotnici = int.Parse(Console.ReadLine());
            int rabotniDni = int.Parse(Console.ReadLine());

            double izraboteniChasove = (rabotnici * rabotniDni) * 8;
            double ostavashtiChasove = Math.Abs(izraboteniChasove - chasove);
            double neustoiki = ostavashtiChasove * rabotniDni;

            if (izraboteniChasove >= chasove)
            {
                Console.WriteLine("{0} hours left", ostavashtiChasove);
            }
            else if (chasove > izraboteniChasove)
            {
                Console.WriteLine("{0} overtime", ostavashtiChasove);
                Console.WriteLine("Penalties: {0}", neustoiki);
            }

        }
    }
}
