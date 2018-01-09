using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacii_Random_Chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            double[] x = new double[1000];

            double a = random.Next(x.Length);
            double b = random.Next(x.Length);

            double sumirane = a + b;
            double izvajdane = a - b;
            double umnojenie = a * b;
            double delenie = a / b;
            double pitagor = Math.Sqrt(a * a + b * b);
         
            Console.WriteLine("{0} + {1} = {2}", a, b, sumirane);
            Console.WriteLine("{0} - {1} = {2}", a, b, izvajdane);
            Console.WriteLine("{0} * {1} = {2}", a, b, umnojenie);
            Console.WriteLine("{0} / {1} = {2}", a, b, delenie);
            Console.WriteLine("Питагорова теорема: " + pitagor);
        }
    }
}