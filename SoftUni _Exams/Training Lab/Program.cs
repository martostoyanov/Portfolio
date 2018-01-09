using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double dalzhina = double.Parse(Console.ReadLine());
            double shirochina = double.Parse(Console.ReadLine());
            double redove = Math.Floor((dalzhina * 100) / 120);
            double bjura = Math.Floor(((shirochina * 100) - 100) / 70);
            double mesta = redove * bjura - 3;
            Console.WriteLine(mesta);
        }
    }
}
