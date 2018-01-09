using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_competition
{
    class Program
    {
        static void Main(string[] args)
        {
            double broiTanciori = double.Parse(Console.ReadLine());
            double tochki = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            string mqsto = Console.ReadLine();

            if (mqsto == "Bulgaria")
            {
                if (sezon == "summer")
                {
                    double pari = broiTanciori * tochki;
                    double pariRazhodi = pari - (pari * 0.05);
                    double blagotvoritelnost = pariRazhodi * 0.75;
                    double ostanaliPari = pariRazhodi - blagotvoritelnost;
                    double pariTancior = ostanaliPari / broiTanciori;

                    Console.WriteLine("Charity - {0:f2}", blagotvoritelnost);
                    Console.WriteLine("Money per dancer - {0:f2}", pariTancior);
                }
                else if (sezon == "winter")
                {
                    double pari = broiTanciori * tochki;
                    double pariRazhodi = pari - (pari * 0.08);
                    double blagotvoritelnost = pariRazhodi * 0.75;
                    double ostanaliPari = pariRazhodi - blagotvoritelnost;
                    double pariTancior = ostanaliPari / broiTanciori;

                    Console.WriteLine("Charity - {0:f2}", blagotvoritelnost);
                    Console.WriteLine("Money per dancer - {0:f2}", pariTancior);
                }
            }

            if (mqsto == "Abroad")
            {
                if (sezon == "summer")
                {
                    double pari = (broiTanciori * tochki) + (broiTanciori * tochki * 0.5);
                    double pariRazhodi = pari - (pari * 0.10);
                    double blagotvoritelnost = pariRazhodi * 0.75;
                    double ostanaliPari = pariRazhodi - blagotvoritelnost;
                    double pariTancior = ostanaliPari / broiTanciori;

                    Console.WriteLine("Charity - {0:f2}", blagotvoritelnost);
                    Console.WriteLine("Money per dancer - {0:f2}", pariTancior);
                }
                else if (sezon == "winter")
                {
                    double pari = (broiTanciori * tochki) + (broiTanciori * tochki * 0.5);
                    double pariRazhodi = pari - (pari * 0.15);
                    double blagotvoritelnost = pariRazhodi * 0.75;
                    double ostanaliPari = pariRazhodi - blagotvoritelnost;
                    double pariTancior = ostanaliPari / broiTanciori;

                    Console.WriteLine("Charity - {0:f2}", blagotvoritelnost);
                    Console.WriteLine("Money per dancer - {0:f2}", pariTancior);
                }
            }

        }
    }
}
