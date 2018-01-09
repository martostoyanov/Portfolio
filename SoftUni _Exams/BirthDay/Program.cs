using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            //vhod
            double dalzhina = double.Parse(Console.ReadLine());
            double shirochina = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            //kalkulacii
            double obem = dalzhina * shirochina * visochina;
            double obshtoLitri = obem * 0.001;
            double procent1 = procent * 0.01;
            double litri = obshtoLitri * (1 - procent1);

            //izhod
            Console.WriteLine($"{litri:f3}");

        }
    }
}
