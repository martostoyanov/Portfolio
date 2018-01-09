using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_race
{
    class Program
    {
        static void Main(string[] args)
        {
            double mladshi = double.Parse(Console.ReadLine());
            double starshi = double.Parse(Console.ReadLine());
            string sastezanie = Console.ReadLine();

            double taksaMladshi = 0;
            double taksaStarshi = 0;
            double suma = 0;

            if (sastezanie == "cross-country")
            {
                taksaMladshi = 8;
                taksaStarshi = 9.50;
                
            }
            else if (sastezanie == "trail")
            {
                taksaMladshi = 5.50;
                taksaStarshi = 7;
            }
            else if (sastezanie == "downhill")
            {
                taksaMladshi = 12.25;
                taksaStarshi = 13.75;
            }
            else if (sastezanie == "road")
            {
                taksaMladshi = 20;
                taksaStarshi = 21.50;
            }

            if (mladshi + starshi >= 50 && sastezanie == "cross-country")
            {
                double sumaMlad = mladshi * taksaMladshi;
                double sumaStar = starshi * taksaStarshi;
                suma = (sumaMlad + sumaStar) - ((sumaMlad + sumaStar) * 0.25);
                suma = suma - (suma * 0.05);

                Console.WriteLine("{0:f2}", suma);
            }

            else
            {
                double sumaMlashi = mladshi * taksaMladshi;
                double sumaStarshi = starshi * taksaStarshi;
                suma = sumaMlashi + sumaStarshi;
                suma = suma - (suma * 0.05);

                Console.WriteLine("{0:f2}", suma);
            }
        }
    }
}
