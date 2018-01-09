using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {

            double slabaOcenka = 0;
            double sredOcenka = 0;
            double dobraOcenka = 0;
            double mdOcenka = 0;
            double otOcenka = 0;

            int uchenici = int.Parse(Console.ReadLine());

            for (int i = 0; i < uchenici; i++)
            {
                double ocenka = double.Parse(Console.ReadLine());

                if (ocenka >= 0 && ocenka < 22.5)
                {
                    slabaOcenka++;
                }
                else if (ocenka >= 22.5 && ocenka < 40.5)
                {
                    sredOcenka++;
                }
                else if (ocenka >= 40.5 && ocenka < 58.5)
                {
                    dobraOcenka++;
                }
                else if (ocenka >= 58.5 && ocenka < 76.5)
                {
                    mdOcenka++;
                }
                else if (ocenka >= 76.5 && ocenka <= 100)
                {
                    otOcenka++;
                }
            }

            double slabo = slabaOcenka / uchenici * 100.0;
            double sredno = sredOcenka / uchenici * 100.0;
            double dobra = dobraOcenka / uchenici * 100.0;
            double mnogoDobra = mdOcenka / uchenici * 100.0;
            double otlichna = otOcenka / uchenici * 100.0;

            Console.WriteLine($"{slabo:f2}% poor marks");
            Console.WriteLine($"{sredno:f2}% satisfactory marks");
            Console.WriteLine($"{dobra:f2}% good marks");
            Console.WriteLine($"{mnogoDobra:f2}% very good marks");
            Console.WriteLine($"{otlichna:f2}% excellent marks");
        }
    }
}
