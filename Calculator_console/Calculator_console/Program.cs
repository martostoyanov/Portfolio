using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_console
{
    class Program
    {
        static void Main(string[] args)
        {
            double sbor;
            double izvajdane;
            double umnojenie;
            double delenie;

            Console.Write("Въведете число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Въведете 2 число: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Изберете операция: + за събиране; - за изваждане; * за умножение или / за деление");
            string operacia = Console.ReadLine();
            if (operacia == "+")
            {
                sbor = a + b;
                Console.WriteLine("Сборът от двете числа е {0}", sbor);
            }
            else if (operacia == "-")
            {
                izvajdane = a - b;
                Console.WriteLine("Сумата след изваждането на двете числа е {0}", izvajdane);
            }
            else if (operacia == "*")
            {
                umnojenie = a * b;
                Console.WriteLine("Сумата след умножението на двете числа е {0}", umnojenie);
            }
            else if (operacia == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("На нула не се дели!");
                }
                else
                {
                    delenie = a / b;
                    Console.WriteLine("Сумата след делението на двете числа е {0}", delenie);
                }
            }
        }
    }
}
