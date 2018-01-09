using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {

            //vhod
            string dogovor = Console.ReadLine();
            string tipDogovor = Console.ReadLine();
            string internet = Console.ReadLine();
            int meseci = int.Parse(Console.ReadLine());
            double cena = 0;
            double krainaSuma = 0;

            //proverki + kalkulaciq
            if (dogovor == "one")
            {
                if (tipDogovor == "Small")
                {
                    cena = 9.98;
                    if (internet == "yes")
                    {
                        cena = cena + 5.50;
                    }
                }
                else if (tipDogovor == "Middle")
                {
                    cena = 18.99;
                    if (internet == "yes")
                    {
                        cena = cena + 4.35;
                    }
                }
                else if (tipDogovor == "Large")
                {
                    cena = 25.98;
                    if (internet == "yes")
                    {
                        cena = cena + 4.35;
                    }
                }
                else if (tipDogovor == "ExtraLarge")
                {
                    cena = 35.99;
                    if (internet == "yes")
                    {
                        cena = cena + 3.85;
                    }
                }
                krainaSuma = cena * meseci;
            }
            else if (dogovor == "two")
            {
                if (tipDogovor == "Small")
                {
                    cena = 8.58;
                    if (internet == "yes")
                    {
                        cena = cena + 5.50;
                    }
                }
                else if (tipDogovor == "Middle")
                {
                    cena = 17.09;
                    if (internet == "yes")
                    {
                        cena = cena + 4.35;
                    }
                }
                else if (tipDogovor == "Large")
                {
                    cena = 23.59;
                    if (internet == "yes")
                    {
                        cena = cena + 4.35;
                    }
                }
                else if (tipDogovor == "ExtraLarge")
                {
                    cena = 31.79;
                    if (internet == "yes")
                    {
                        cena = cena + 3.85;
                    }
                }
                double namalenie = (cena * meseci) * 0.0375;
                krainaSuma = (cena * meseci) - namalenie ;
            }

            //izhod
            Console.WriteLine($"{krainaSuma:f2} lv.");
        }
    }
}
