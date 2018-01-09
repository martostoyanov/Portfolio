using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_league
{
    class Program
    {
        static void Main(string[] args)
        {
            double kapacitet = double.Parse(Console.ReadLine());
            double fenove = double.Parse(Console.ReadLine());

            int sektorA = 0;
            int sektorB = 0;
            int sektorV = 0;
            int sektorG = 0;

            for (int i = 1; i <= fenove; i++)
            {
                string sektor = Console.ReadLine();
                if (sektor == "A")
                {
                    sektorA++;
                }
                else if (sektor == "B")
                {
                    sektorB++;
                }
                else if (sektor == "V")
                {
                    sektorV++;
                }
                else if (sektor == "G")
                {
                    sektorG++;
                }
            }

            double procentiA = (sektorA / fenove) * 100.00;
            double procentiB = (sektorB / fenove) * 100.00;
            double procentiV = (sektorV / fenove) * 100.00;
            double procentiG = (sektorG / fenove) * 100.00;
            double procentiStadion = (fenove / kapacitet) * 100.00;

            Console.WriteLine($"{procentiA:f2}%");
            Console.WriteLine($"{procentiB:f2}%");
            Console.WriteLine($"{procentiV:f2}%");
            Console.WriteLine($"{procentiG:f2}%");
            Console.WriteLine($"{procentiStadion:f2}%");

        }
    }
}
