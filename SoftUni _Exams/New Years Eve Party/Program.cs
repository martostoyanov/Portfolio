using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Years_Eve_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double gosti = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double kuvert = gosti * 20;
            double ostavashtiPari = budget - kuvert;
            double foirverki = ostavashtiPari * 0.40;
            double darenie = ostavashtiPari - foirverki;

            if (budget > kuvert)
            {
                
                Console.WriteLine("Yes! {0:f0} lv are for fireworks and {1:f0} lv are for donation.", foirverki, darenie);
            }
            else if (kuvert > ostavashtiPari)
            {
                Console.WriteLine("They won't have enough money to pay the covert. They will need {0:f0} lv more.", Math.Abs(ostavashtiPari));
            }
      
        }
    }
}
