using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double studenti = double.Parse(Console.ReadLine());

            int slab = 0;
            int sreden = 0;
            int dobar = 0;
            int top = 0;

            double uspeh = 0;

            for (int i = 0; i < studenti; i++)
            {
                double ocenka = double.Parse(Console.ReadLine());
                if (ocenka >= 2 && ocenka <= 2.99)
                {
                    slab++;
                    uspeh += ocenka;
                }
                if (ocenka >= 3 && ocenka <= 3.99)
                {
                    sreden++;
                    uspeh += ocenka;
                }
                if (ocenka >= 4 && ocenka <= 4.99)
                {
                    dobar++;
                    uspeh += ocenka;
                }
                if (ocenka >= 5 && ocenka <= 6)
                {
                    top++;
                    uspeh += ocenka;
                }
            }

            double average = uspeh / studenti;
            double topStud = top / studenti * 100;
            double dobStud = dobar / studenti * 100;
            double sredStud = sreden / studenti * 100;
            double slabStud = slab / studenti * 100;

            Console.WriteLine($"Top students: {topStud:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {dobStud:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {sredStud:f2}%");
            Console.WriteLine($"Fail: {slabStud:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
