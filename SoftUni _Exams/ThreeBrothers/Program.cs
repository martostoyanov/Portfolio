using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            //vhod
            double golqmBrat = double.Parse(Console.ReadLine());
            double sredenBrat = double.Parse(Console.ReadLine());
            double malykBrat = double.Parse(Console.ReadLine());
            double bashtaMissing = double.Parse(Console.ReadLine());

            //kalkulacii
            double vremeChistene = 1 / (1 / golqmBrat + 1 / sredenBrat + 1 / malykBrat);
            double obshtoVreme = vremeChistene + (vremeChistene * 0.15);
            double ostavashtoVreme = bashtaMissing - obshtoVreme;

            //proverka + izhod
            Console.WriteLine($"Cleaning time: {obshtoVreme:f2}");
            if (ostavashtoVreme > 0)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(ostavashtoVreme));
            }
            else
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Abs(Math.Floor(ostavashtoVreme)));
            }
         
            
        }
    }
}
