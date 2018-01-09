using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var chas = int.Parse(Console.ReadLine());
            var minumum = int.Parse(Console.ReadLine());
            var pristigane = int.Parse(Console.ReadLine());
            var minPristigane = int.Parse(Console.ReadLine());
 
            double izpit = chas * 60 + minumum;
            double pristiganeIzpit = pristigane * 60 + minPristigane;
 
            double chasZak = 0;
            double minZak = 0;
            double chasPodr = 0;
            double minPodr = 0;
            double zakMin = 0;
            double podrMin = 0;
            double navreme = 0;
 
            if (pristiganeIzpit > izpit)
            {
                Console.WriteLine("Late");
                if (pristiganeIzpit - izpit > 59)
                {
                    chasZak = Math.Truncate((pristiganeIzpit - izpit) / 60);
                    minZak = pristiganeIzpit - izpit - (chasZak * 60);
                    if (minZak < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", chasZak, minZak);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours after the start", chasZak, minZak);
                    }
                }
                else
                {
                    zakMin = pristiganeIzpit - izpit;
                    if (zakMin < 10)
                    {
                        Console.WriteLine("{0} minutes after the start", zakMin);
                    }
                    else
                    {
                        Console.WriteLine("{0} minutes after the start", zakMin);
                    }
                }
            }
            else if (izpit > pristiganeIzpit + 30)
            {
                Console.WriteLine("Early");
                if (izpit - pristiganeIzpit > 59)
                {
                    chasPodr = Math.Truncate((izpit - pristiganeIzpit) / 60);
                    minPodr = izpit - pristiganeIzpit - chasPodr * 60;
                    if (minPodr < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours before the start", chasPodr, minPodr);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours before the start", chasPodr, minPodr);
                    }
                }
                else
                {
                    podrMin = izpit - pristiganeIzpit;
 
                    Console.WriteLine("{0} minutes before the start", podrMin);
                }
            }
            else if (pristiganeIzpit < izpit)
            {
                navreme = izpit - pristiganeIzpit;
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", navreme);
            }
            else if (pristiganeIzpit == izpit)
            {
                Console.WriteLine("On time");
            }
        }
    }
}
