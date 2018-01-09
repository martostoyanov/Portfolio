using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_loss
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int dni = int.Parse(Console.ReadLine());
            int tanciori = int.Parse(Console.ReadLine());

            double energiq = 0;
            double obshtaEnergia = 100 * dni * tanciori;

            for (int i = 1; i <= dni; i++)
              {
                 int chasove = int.Parse(Console.ReadLine());

                    if (i % 2 == 0 && chasove % 2 == 0)
                    {
                        energiq = energiq + 68;
                    }
                    else if (i % 2 == 1 && chasove % 2 == 0)
                    {
                        energiq = energiq + 49;
                    }
                    else if (i % 2 == 0 && chasove % 2 == 1)
                    {
                        energiq = energiq + 65;
                    }
                    else if (i % 2 == 1 && chasove % 2 == 1)
                    {
                        energiq = energiq + 30;
                    }
                }

              double ostanalaEnergiq = obshtaEnergia - (energiq * tanciori);
              double energyLeftPerDancer = ostanalaEnergiq / tanciori / dni;

              if (energyLeftPerDancer <= 50)
              {
                  Console.WriteLine($"They are wasted! Energy left: {energyLeftPerDancer:f2}");
              }
              else
              {
                  Console.WriteLine($"They feel good! Energy left: {energyLeftPerDancer:f2}");
              }
            
         }
    }
}
