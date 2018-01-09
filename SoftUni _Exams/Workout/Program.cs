using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            double km = double.Parse(Console.ReadLine());

            double sborKm = km;

            for (int i = 0; i < dni; i++)
            {
                double procenti = double.Parse(Console.ReadLine()) / 100;
                km = km + (km * procenti);
                sborKm = sborKm + km;
            }

            double norma = Math.Ceiling(Math.Abs(1000 - sborKm));

            if (sborKm >= 1000)
            {
                Console.WriteLine("You've done a great job running {0} more kilometers!", norma);
            }
            else
            {
                Console.WriteLine("Sorry Mrs. Ivanova, you need to run {0} more kilometers", norma);
            }
        }
    }
}
