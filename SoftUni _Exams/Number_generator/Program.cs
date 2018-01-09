using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialnoChislo = int.Parse(Console.ReadLine());
            int kontrolnoChislo = int.Parse(Console.ReadLine());
           
            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        string chislo = i + "" + j + "" + k + "";
                        int proverka = int.Parse(chislo);
                        if (proverka % 3 == 0)
                        {
                            specialnoChislo = specialnoChislo + 5;
                        }
                        else if (proverka % 10 == 5)
                        {
                            specialnoChislo = specialnoChislo - 2;
                        }
                        else if (proverka % 2 == 0)
                        {
                            specialnoChislo = specialnoChislo * 2;
                        }

                        if (specialnoChislo >= kontrolnoChislo)
                        {
                            break;
                        }
                    }
                    if (specialnoChislo >= kontrolnoChislo)
                    {
                        break;
                    }
                }
                if (specialnoChislo >= kontrolnoChislo)
                {
                    break;
                }
            }

            if (specialnoChislo >= kontrolnoChislo)
            {
                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialnoChislo);
            }
            else
            {
                Console.WriteLine("No! {0} is the last reached special number.", specialnoChislo);
            }
        }
    }
}