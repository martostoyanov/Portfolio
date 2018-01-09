using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvetovenRekordPluvane
{
    class Program
    {
        static void Main(string[] args)
        {
            double rekord = double.Parse(Console.ReadLine());
            double distancia = double.Parse(Console.ReadLine());
            double vreme = double.Parse(Console.ReadLine());


            double obshtoPluvane =  distancia * vreme;
            double saprotivlenie = (distancia / 15) * 12.5;
            double krainoVreme = obshtoPluvane + saprotivlenie;
            double ostanaloVreme = krainoVreme - rekord;

            if (krainoVreme < rekord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {krainoVreme:f2} seconds.");
            }
            else if (krainoVreme >= rekord)
            {
                Console.WriteLine($"No, he failed! He was {ostanaloVreme:f2} seconds slower.");
            }
            
        }
    }
}
