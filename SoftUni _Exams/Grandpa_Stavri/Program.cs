using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {

            //vhod
            int broiDni = int.Parse(Console.ReadLine());
            double obshtoLitri = 0;
            double sborGradusi = 0;
            double kraenGradus = 0;
            double godenGradus = 0;

            //cikal + kalkulirane
            for (int i = 0; i < broiDni; i++)
            {
                double kolichestvo = double.Parse(Console.ReadLine());
                double gradusi = double.Parse(Console.ReadLine());
                obshtoLitri += kolichestvo;
                sborGradusi = kolichestvo * gradusi;
                kraenGradus += sborGradusi;
            }
            godenGradus = kraenGradus / obshtoLitri;
            Console.WriteLine($"Liter: {obshtoLitri:f2}");
            Console.WriteLine($"Degrees: {godenGradus:f2}");

            //proverki + izhod
            if (godenGradus < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (godenGradus >= 38 && godenGradus <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (godenGradus > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }


    }
}
