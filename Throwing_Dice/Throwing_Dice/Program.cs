using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throwing_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int proverka = 999;

            Random dice = new Random();

            //Правила
            Console.WriteLine("Правила: Двама играчи се съгласуват какъв да е залога. Залогът е сбора от сумата на зарчетата.");
            Console.WriteLine("Минимумът е 5 и макс 30. Всеки играч хвърля зара по 5 пъти.");
            Console.WriteLine("Победител е този, който го е уцелил.");
            Console.WriteLine();
            Console.Write("Име на Играч 1: ");
            string p1 = Console.ReadLine();
            Console.Write("Име на Играч 2: ");
            string p2 = Console.ReadLine();

            //Залог
            Console.Write("Задайте залог: ");
            int zalog = int.Parse(Console.ReadLine());
            for (int i = 0; i < proverka; i++)
            {
                if (zalog < 5 || zalog > 30)
                {
                    Console.WriteLine("Невалиден залог!");
                    Console.Write("Задайте залог: ");
                    zalog = int.Parse(Console.ReadLine());
                }
            }
            //Игра
            Console.WriteLine();
            Console.WriteLine(p1 + " натисни Enter да хвърлиш зарчетата");
            Console.ReadLine();
            Console.WriteLine(p1);
            int hvurlqne1 = dice.Next(1, 7);
            int hvurlqne2 = dice.Next(1, 7);
            int hvurlqne3 = dice.Next(1, 7);
            int hvurlqne4 = dice.Next(1, 7);
            int hvurlqne5 = dice.Next(1, 7);
            int dice_sum = hvurlqne1 + hvurlqne2 + hvurlqne3 + hvurlqne4 + hvurlqne5;
            Console.WriteLine("Хвърляне номер 1: " + hvurlqne1);
            Console.WriteLine("Хвърляне номер 2: " + hvurlqne2);
            Console.WriteLine("Хвърляне номер 3: " + hvurlqne3);
            Console.WriteLine("Хвърляне номер 4: " + hvurlqne4);
            Console.WriteLine("Хвърляне номер 5: " + hvurlqne5);
            Console.WriteLine("Обща сума на 5-те хвърляния: " + dice_sum);
          
            if (zalog == dice_sum)
            {
                Console.WriteLine("{0} хвърли точно колкото залога!", p1);
            }
            else
            {
                Console.WriteLine("{0} не успя да хвърли колкото залога", p1);
            }
            //
            Console.WriteLine();
            Console.WriteLine(p2 + " натисни Enter да хвърлиш зарчетата");
            Console.ReadLine();
            Console.WriteLine(p2);

            int hvurlqne6 = dice.Next(1, 7);
            int hvurlqne7 = dice.Next(1, 7);
            int hvurlqne8 = dice.Next(1, 7);
            int hvurlqne9 = dice.Next(1, 7);
            int hvurlqne10 = dice.Next(1, 7);
            int dice_sum2 = hvurlqne10 + hvurlqne6 + hvurlqne7 + hvurlqne8 + hvurlqne9;
            Console.WriteLine("Хвърляне номер 1: " + hvurlqne6);
            Console.WriteLine("Хвърляне номер 2: " + hvurlqne7);
            Console.WriteLine("Хвърляне номер 3: " + hvurlqne8);
            Console.WriteLine("Хвърляне номер 4: " + hvurlqne9);
            Console.WriteLine("Хвърляне номер 5: " + hvurlqne10);
            Console.WriteLine("Обща сума на 5-те хвърляния: " + dice_sum2);

            if (zalog == dice_sum2)
            {
                Console.WriteLine("{0} хвърли точно колкото залога!", p2);
            }
            else
            {
                Console.WriteLine("{0} не успя да хвърли колкото залога", p2);
            }

            //Winning conditions
            Console.WriteLine();
            if (dice_sum == zalog)
            {
                Console.WriteLine("{0} печели!", p1);
            }
            else if (dice_sum2 == zalog)
            {
                Console.WriteLine("{0} печели!", p2);
            }
            else if (dice_sum == zalog && dice_sum2 == zalog)
            {
                Console.WriteLine("{0} и {1} печелят, защото са уцелили колкото залога!", p1, p2);
            }
            else
            {
                Console.WriteLine("Няма победител!");
            }
        }
    }
}