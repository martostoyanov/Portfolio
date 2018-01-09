using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacktothePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double nastledstvo = double.Parse(Console.ReadLine());
            int godina = int.Parse(Console.ReadLine());

            int ivancho = 18;

            for (int i = 1800; i <= godina; i++)
            {
                if (i % 2 == 0)
                {
                    nastledstvo -= 12000;
                }
                else
                {
                    nastledstvo -=(12000 + 50 * ivancho);
                }
                godina++;
            }


            if (nastledstvo < 0)
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", nastledstvo);
            }
            else
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", nastledstvo);
            }
        }
    }
}
