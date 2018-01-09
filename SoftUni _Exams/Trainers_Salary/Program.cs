using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lekcii = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            int jelev = 0;
            int royal = 0;
            int roli = 0;
            int trifon = 0;
            int sino = 0;
            int drugi = 0;

            for (int i = 0; i < lekcii; i++)
            {
                string lektor = Console.ReadLine();
                if (lektor == "Jelev") jelev++;
                if (lektor == "RoYaL") royal++;
                if (lektor == "Roli") roli++;
                if (lektor == "Trofon") trifon++;
                if (lektor == "Sino") sino++;
                if (lektor != "Jelev" && lektor != "RoYaL" && lektor != "Roli" && lektor != "Trofon" && lektor != "Sino") drugi++;
            }

            double lekciq = budget / lekcii;

            Console.WriteLine("Jelev salary: {0:f2} lv", jelev * lekciq);
            Console.WriteLine("RoYaL salary: {0:f2} lv", royal * lekciq);
            Console.WriteLine("Roli salary: {0:f2} lv", roli * lekciq);
            Console.WriteLine("Trofon salary: {0:f2} lv", trifon * lekciq);
            Console.WriteLine("Sino salary: {0:f2} lv", sino * lekciq);
            Console.WriteLine("Others salary: {0:f2} lv", drugi * lekciq);
        }
    }
}
