using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double hodove = double.Parse(Console.ReadLine());

            double rezultat = 0;

            int nulaDeved = 0;
            int desetDeved = 0;
            int dvaiseDeved = 0;
            int triiseDeved = 0;
            int chetiriPetdeset = 0;
            int invalid = 0;

            for (int i = 0; i < hodove; i++)
            {
                double chisla = double.Parse(Console.ReadLine());
                if (chisla >= 0 && chisla <=9)
                {
                    nulaDeved++;
                    rezultat += chisla * 0.20;
                }
                if (chisla >= 10  && chisla <= 19)
                {
                    desetDeved++;
                    rezultat += chisla * 0.30;
                }
                if (chisla >= 20 && chisla <= 29)
                {
                    dvaiseDeved++;
                    rezultat += chisla * 0.40;
                }
                if (chisla >= 30 && chisla <= 39)
                {
                    triiseDeved++;
                    rezultat += 50;
                }
                if (chisla >= 40 && chisla <= 50)
                {
                    chetiriPetdeset++;
                    rezultat += 100;
                }
                if (chisla < 0 || chisla > 50)
                {
                    invalid++;
                    rezultat = rezultat / 2.0;
                }
                
            }
            double nd = nulaDeved / hodove * 100;
            double ed = desetDeved / hodove * 100;
            double dd = dvaiseDeved / hodove * 100;
            double td = triiseDeved / hodove * 100;
            double cp = chetiriPetdeset / hodove * 100;
            double inv = invalid / hodove * 100;

            Console.WriteLine($"{rezultat:f2}");
            Console.WriteLine("From 0 to 9: {0:f2}%",nd);
            Console.WriteLine("From 10 to 19: {0:f2}%", ed);
            Console.WriteLine("From 20 to 29: {0:f2}%", dd);
            Console.WriteLine("From 30 to 39: {0:f2}%", td);
            Console.WriteLine("From 40 to 50: {0:f2}%", cp);
            Console.WriteLine("Invalid numbers: {0:f2}%", inv);
        }
    }
}
